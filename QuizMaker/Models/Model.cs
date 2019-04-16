using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Model
    {
        private Quiz quiz;
        public Model()
        {
            quiz = new Quiz();
        }


        public List<Tuple<string, uint, string[], bool[]>> GetQuestions
        {
            get
            {
                return quiz.GetQuestionTuples();
            }
        }
        public void AddQuestion(string text, string[] answers, bool[] isCorrect, uint points)
        {
            if(text == "")
            {
                throw new Exception("Question text cannot be blank.");
            }
            else if (answers.Length < 2)
            {
                throw new Exception("Add at least 2 answers.");
            }
            else
            {
                quiz.questions.Add(new Question(text, answers, isCorrect, points));
            }
        }
        public void EditQuestion(int index, string text, string[] answers, bool[] isCorrect, uint points)
        {
            quiz.questions[index] = new Question(text, answers, isCorrect, points);
        }
        public void DeleteQuestion(int index)
        {
            if(index!=-1) quiz.questions.RemoveAt(index);
        }
        // method used to debug
        public void PrintQuestions()
        {
            foreach(Question q in quiz.questions)
            {
                Console.WriteLine(q);
            }
        }
    }
}
