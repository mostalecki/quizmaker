using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Question
    {
        private string text;
        private List<string> answers;
        private List<bool> isCorrect;
        private uint points;

        public Question()
        {
            answers = new List<string>();
            isCorrect = new List<bool>();
        }
    }
}
