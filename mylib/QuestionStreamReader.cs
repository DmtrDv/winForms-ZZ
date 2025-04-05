using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylib
{
    public class QuestionStreamReader
    {
        public storage ReadDisciplines(string PathToListDisciplines, storage Discipline)
        {
            using (StreamReader SR = new StreamReader(PathToListDisciplines))
            {
                string sr = Convert.ToString(SR.ReadToEnd());

                string[] EnumerationOfDisciplines = sr.Split(';');

                for (int i = 0; i < EnumerationOfDisciplines.Length; i++)
                {
                    Discipline.AddDiscipline(EnumerationOfDisciplines[i]);
                }
            }
            return Discipline;
        }

        public storage ReadListQuestions(string PartPathToListQuestion, storage ListQuiestions)
        {
            string PathToListQuestion = $"FolderLists\\{PartPathToListQuestion}\\{PartPathToListQuestion}.txt";
            using (StreamReader SR = new StreamReader(PathToListQuestion))
            {
                string readable = Convert.ToString(SR.ReadToEnd());
                string[] AlreadyReadStrings = readable.Split('\n');
                string[] AlreadyRead = null;
                for (int i = 0; i < AlreadyReadStrings.Length; i++)
                {
                    if (AlreadyReadStrings[i] == "") { }
                    else
                    {
                        AlreadyRead = AlreadyReadStrings[i].Split('~');
                        string Question = $"{i + 1} " + AlreadyRead[0];
                        string RightAnswer = "\nПравильный ответ: " + AlreadyRead[1] + " ";
                        string VarintsAnswer = null;

                        for (int j = 2; j < AlreadyRead.Length; j++)
                        {
                            VarintsAnswer += AlreadyRead[j] + '\n';
                        }
                        ListQuiestions.AddQuestion(Question + RightAnswer + "\n" + "Все ответы: " + "\n" + VarintsAnswer);
                    }
                }
            }
            return ListQuiestions;
        }
    }
}
