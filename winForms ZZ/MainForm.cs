using mylib;
using System;
using System.Data.OleDb;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winForms_ZZ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        const string Path = "FolderLists\\Disciple.txt";

        storage AllDiscipline = new storage();
        storage AllQuestions = new storage();

        QuestionStreamReader ReaderDisciplines = new QuestionStreamReader();
        QuestionStreamReader ReaderQuestions = new QuestionStreamReader();

        private void InitializeForm()
        {
            // Заполнение ComboBox дисциплинами
            ReaderDisciplines.ReadDisciplines(Path, AllDiscipline);
            foreach (var discipline in AllDiscipline.getDiscipline())
            {
                ListDisciplines_comboBox.Items.Add(discipline);
            }
            // Подписка на событие выбора элемента в ComboBox
            ListDisciplines_comboBox.SelectedIndexChanged += ListDisciplines_comboBox_SelectedIndexChanged;
        }

        

        private void ListDisciplines_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очистка RichTextBox перед загрузкой новых вопросов
            ListQueshions_RichTextBox.Clear();

            // Проверка, что выбран элемент
            //Если SelectedItem = null,то ничего не выбрано, и код не будет выполнен
            if (ListDisciplines_comboBox.SelectedItem != null)
            {    
                string selectedDiscipline = ListDisciplines_comboBox.SelectedItem.ToString();
                // выгрузка вопросов
                storage AllQuestions = new storage();
                AllQuestions = ReaderQuestions.ReadListQuestions(selectedDiscipline, AllQuestions);
                //проходит по вопросам и загружает их в RichTextBox
                foreach (var question in AllQuestions.getListQuiestions())
                {
                     ListQueshions_RichTextBox.AppendText(question + "\n");
                    //ListQueshions_RichTextBox.Text += question + "\n";
                }
            }
        }
    }





}

    





        // string IntroducedDiscipline = Console.ReadLine();

        //Console.WriteLine("Вот все вопросы по дисциплине: \n");
        //Console.WriteLine(String.Join("\n", ReaderQuestions.ReadListQuestions(IntroducedDiscipline, AllQuestions).getListQuiestions()));

        //Console.WriteLine("Введите необходимые номера вопросов для тестов: ");
        //  int numbersQuestions = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine(numbersQuestions);


        //Console.ReadKey();

    


