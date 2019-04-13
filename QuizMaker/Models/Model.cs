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
        public Question[] GetQuestions
        {
            get
            {
                return quiz.questions.ToArray();
            }
        }
        public Model() {
            quiz = new Quiz();
        }
        public void AddQuestion(string text, string[] answers, bool[] isCorrect, uint points)
        {
            quiz.questions.Add(new Question(text, answers, isCorrect, points));
        }
        public void EditQuestion(int index)
        {
            //TODO
            Console.WriteLine(index);
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
