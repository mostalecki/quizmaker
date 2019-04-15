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
        public List<Question> questions;
        public uint totalPoints;

        public Quiz()
        {
            questions = new List<Question>();
        }
        public List<Tuple<string, uint, string[], bool[]>> GetQuestionTuples()
        {
            return (from n in Enumerable.Range(0, questions.Count) select questions[n].GetTuple()).ToList();
        }
    }
}
