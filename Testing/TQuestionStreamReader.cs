using System;
using System.IO;
using LanguageExt.ClassInstances.Pred;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using mylib;
using NUnit.Framework;
using winForms_ZZ;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Testing
{
    [TestClass]
    public class TQuestionStreamReader
    {
        [TestMethod]
        public storage TestReadDisciplines()
        { }
        private TQuestionStreamReader _yourClassInstance;
        private Mock<storage> _mockStorage;

        [SetUp]
        public void Setup()
        {
            _yourClassInstance = new TQuestionStreamReader(); // Замените на ваше имя класса
            _mockStorage = new Mock<storage>();
        }

        [Test]
        public void ReadListQuestions_ShouldPopulateStorageWithQuestions()
        {
            // Arrange
            string partPathToListQuestion = "TestFolder";
            string testQuestions = "Question1~Answer1~Variant1.1~Variant1.2\n" +
                                   "Question2~Answer2~Variant2.1~Variant2.2\n";

            // Создаем временный файл с тестовыми вопросами
            File.WriteAllText($"FolderLists\\{partPathToListQuestion}\\{partPathToListQuestion}.txt", testQuestions);

            // Настраиваем Mock для метода AddQuestion
            _mockStorage.Setup(s => s.AddQuestion(It.IsAny<string>())).Callback<string>(question =>
            {
                Assert.IsTrue(question.Contains("Question1"));
                Assert.IsTrue(question.Contains("Правильный ответ: Answer1"));
            });

            // Act
            var result = _yourClassInstance.ReadListQuestions(partPathToListQuestion, _mockStorage.Object);

            // Assert
            Assert.AreEqual(_mockStorage.Object, result);
        }

        private storage ReadListQuestions(string partPathToListQuestion, storage @object)
        {
            throw new NotImplementedException();
        }

        [TearDown]
        public void Cleanup()
        {
            // Удаляем временный файл
            string filePath = $"FolderLists\\TestFolder\\TestFolder.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
    

