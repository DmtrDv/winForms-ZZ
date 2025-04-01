using mylib;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winForms_ZZ
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }

            const string Path = "FolderLists\\Disciple.txt";

            storage AllDiscipline = new storage();
            storage AllQuestions = new storage();

            QuestionStreamReader reader = new QuestionStreamReader();
        private void InitializeForm()
        {
            // Заполнение ComboBox группами блюд
            reader.ReadDisciplines(Path, AllDiscipline);
            foreach (var discipline in AllDiscipline.getDiscipline())
            {
                ListDisciplines_comboBox.Items.Add(discipline);
            }

                
        }

        

        

        

        // string IntroducedDiscipline = Console.ReadLine();

        //Console.WriteLine("Вот все вопросы по дисциплине: \n");
        //Console.WriteLine(String.Join("\n", ReaderQuestions.ReadListQuestions(IntroducedDiscipline, AllQuestions).getListQuiestions()));

        //Console.WriteLine("Введите необходимые номера вопросов для тестов: ");
        //  int numbersQuestions = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine(numbersQuestions);


        //Console.ReadKey();

    }
}

