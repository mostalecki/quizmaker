using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    interface IView
    {
        string QuizTitle { get; set; }
        string Question { get; set; }
        List<Question> Questions { set; }
        List<Answer> Answers { get; set; }
        bool[] IsCorrect { get; set; }
        uint Points { get; set; }
        uint TotalPoints { set; }
        event Action AddQuestion;
        event Action<int> EditQuestion;
        event Action<int> DeleteQuestion;
        event Action<int> SelectQuestion;
        event Action<string> SaveQuiz;
        event Action<string> LoadQuiz;
        event Action PostQuiz;
        void ShowMessage(string messageText);
        void ClearEntries();

    }
}
