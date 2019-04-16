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
            this.view.SaveQuiz += SaveQuiz;
            this.view.LoadQuiz += LoadQuiz;
        }
        private void AddQuestion()
        {
            model.AddQuestion(view.Question, view.Answers, view.IsCorrect, view.Points);
            ReloadView();
        }
        private void EditQuestion(int index)
        {
            model.EditQuestion(index, view.Question, view.Answers, view.IsCorrect, view.Points);
            ReloadView();
        }
        private void DeleteQuestion(int index)
        {
            model.DeleteQuestion(index);
            ReloadView();
        }
        private void SelectQuestion(int index)
        {
            Tuple<string, uint, string[], bool[]> selectedQuestion = model.GetSelectedQuestion(index);
            view.Question = selectedQuestion.Item1;
            view.Points = selectedQuestion.Item2;
            view.Answers = selectedQuestion.Item3;
            view.IsCorrect = selectedQuestion.Item4;
        }
        private void SaveQuiz(string path)
        {
            model.QuizTitle = view.QuizTitle;
            model.SaveQuiz(path);
        }
        private void LoadQuiz(string path)
        {
            try
            {
                model.LoadQuiz(path);
                view.QuizTitle = model.QuizTitle;
                view.TotalPoints = model.TotalPoints;
                view.Questions = model.GetQuestions;
            }
            catch(Exception e)
            {
                view.ShowMessage(e.Message);
            }
        }
        private void ReloadView()
        {
            view.ClearEntries();
            view.Questions = model.GetQuestions;
            view.TotalPoints = model.TotalPoints;
        }
    }
}
