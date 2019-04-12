using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Question
    {
        public string text;
        public List<string> answers;
        public List<bool> isCorrect;
        public uint points;

        public Question()
        {
            answers = new List<string>();
            isCorrect = new List<bool>();
        }
    }
}
