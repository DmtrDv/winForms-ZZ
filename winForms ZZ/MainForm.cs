using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForms_ZZ
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        static void Main(string[] args)
        {
            const string Path = "FolderLists\\Disciple.txt";

            storage AllDiscipline = new storage();
            storage AllQuestions = new storage();

            QuestionStreamReader ReaderDisciplines = new QuestionStreamReader();
            QuestionStreamReader ReaderQuestions = new QuestionStreamReader();
            ReaderDisciplines.ReadDisciplines(Path, AllDiscipline);

            Console.WriteLine($"Введите одну из дисциплин: {String.Join(", ", AllDiscipline.getDiscipline())}");

            string IntroducedDiscipline = Console.ReadLine();

            Console.WriteLine("Вот все вопросы по дисциплине: \n");
            Console.WriteLine(String.Join("\n", ReaderQuestions.ReadListQuestions(IntroducedDiscipline, AllQuestions).getListQuiestions()));

            Console.WriteLine("Введите необходимые номера вопросов для тестов: ");
            int numbersQuestions = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(numbersQuestions);


            Console.ReadKey();
        }
    }
}

