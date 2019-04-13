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
        //public List<string> answers;
        //public List<bool> isCorrect;
        public string[] answers;
        public bool[] isCorrect;
        public uint points;

        public Question(string text, string[] answers, bool[] isCorrect, uint points)
        {
            this.text = text;
            this.answers = answers;
            this.isCorrect = isCorrect;
            this.points = points;
        }
        public override string ToString()
        {
            return $"{text} {points}";
        }
    }
}
