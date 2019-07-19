using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Quiz
    {
        public string title;
        public uint totalPoints;
        public List<Question> questions;

        public Quiz()
        {
            questions = new List<Question>();
        }
    }
}
