using mylib;
using System;
using System.Data.OleDb;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

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
            listView1.Items.Clear();

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
                    //listView1.Text += question + "\n";
                    ListViewItem item = new ListViewItem(question + "\n");
                    listView1.Items.Add(item);
                }
            }
        }

        private void Redakt_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Получаем выбранный элемент
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Открываем диалоговое окно для редактирования текста
                using (Form editForm = new Form())
                {
                    var textBox = new TextBox
                    {
                        Text = selectedItem.Text,
                        Dock = DockStyle.Fill
                    };
                    var saveButton = new Button
                    {
                        Text = "Сохранить",
                        Dock = DockStyle.Bottom
                    };

                    saveButton.Click += (s, args) =>
                    {
                        // Сохраняем измененный текст
                        selectedItem.Text = textBox.Text;
                        editForm.Close();
                    };

                    editForm.Controls.Add(textBox);
                    editForm.Controls.Add(saveButton);
                    editForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите вопрос для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    


