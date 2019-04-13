using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Quiz
    {
        private string title;
        private List<Question> questions;
        private uint totalPoints;

        public Quiz()
        {
            questions = new List<Question>();
        }
    }
}
