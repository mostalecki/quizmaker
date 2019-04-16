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
            this.view.SelectQuestion += SelectQuestion;
            //this.view.EditQuestion += PrintQuestions;
        }
        private void AddQuestion()
        {
            try
            {
                model.AddQuestion(view.Question, view.Answers, view.IsCorrect, view.Points);
            }
            catch(Exception e)
            {
                view.ShowMessage(e.Message);
            }
            view.ClearEntries();
            view.Questions = model.GetQuestions;
        }
        private void EditQuestion(int index)
        {
            model.EditQuestion(index, view.Question, view.Answers, view.IsCorrect, view.Points);
            view.ClearEntries();
            view.Questions = model.GetQuestions;
        }
        private void DeleteQuestion(int index)
        {
            model.DeleteQuestion(index);
            view.ClearEntries();
            view.Questions = model.GetQuestions;
        }
        private void SelectQuestion(int index)
        {
            Tuple<string, uint, string[], bool[]> selectedQuestion = model.GetSelectedQuestion(index);
            view.Question = selectedQuestion.Item1;
            view.Points = selectedQuestion.Item2;
            view.Answers = selectedQuestion.Item3;
            view.IsCorrect = selectedQuestion.Item4;
        }
        //method used to debug
        private void PrintQuestions()
        {
            //model.PrintQuestions();
        }
    }
}
