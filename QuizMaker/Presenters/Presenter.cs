using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Presenter
    {
        IView view;
        Model model;
        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.AddQuestion += AddQuestion;
            this.view.EditQuestion += EditQuestion;
            this.view.DeleteQuestion += DeleteQuestion;
            //this.view.EditQuestion += PrintQuestions;
        }
        private void AddQuestion()
        {
            model.AddQuestion(view.Question, view.Answers, view.IsCorrect, view.Points);
        }
        private void EditQuestion(int index)
        {
            model.EditQuestion(index);
        }
        private void DeleteQuestion(int index)
        {
            model.DeleteQuestion(index);
        }
        //method used to debug
        private void PrintQuestions()
        {
            model.PrintQuestions();
        }
    }
}
