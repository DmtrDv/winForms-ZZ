using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylib
{
    public class storage
    {
        List<string> Discipline = new List<string>();

        List<string> ListQuiestions = new List<string>();

        List<string> QuestionsForTest = new List<string>();
        public void AddDiscipline(string List)
        {
            Discipline.Add(List);
        }

        public List<string> getDiscipline()
        {
            return Discipline;
        }
        public List<string> getListQuiestions()
        {
            return ListQuiestions;
        }
        public void AddQuestion(string List)
        {
            ListQuiestions.Add(List);
        }
        public void AddQuestionForTest(string List)
        {
            QuestionsForTest.Add(List);
        }
    }
}

