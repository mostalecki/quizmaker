using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class Question
    {
        public string text;
        //public List<string> answers;
        //public List<bool> isCorrect;
        public Answer[] AAnswers;
        public string[] answers;
        public bool[] isCorrect;
        public uint points;

        public Question(string text, string[] answers, bool[] isCorrect, uint points)
        {
            AAnswers = new Answer[answers.Length];
            for(int i = 0; i < answers.Length; i++)
            {
                AAnswers[i] = new Answer(answers[i], isCorrect[i]);
            }
            this.text = text;
            this.answers = answers;
            this.isCorrect = isCorrect;
            this.points = points;
        }
        public void Update(string text, string[] answers, bool[] isCorrect, uint points)
        {
            AAnswers = new Answer[answers.Length];
            for (int i = 0; i < answers.Length; i++)
            {
                AAnswers[i] = new Answer(answers[i], isCorrect[i]);
            }
            this.text = text;
            this.answers = answers;
            this.isCorrect = isCorrect;
            this.points = points;
        }
        public override string ToString()
        {
            return $"{text} {points}";
        }
        public Tuple<string, uint, string[], bool[]> GetTuple()
        {
            string[] answers = (from n in Enumerable.Range(0, AAnswers.Length) select AAnswers[n].text).ToArray();
            bool[] isCorrect = (from n in Enumerable.Range(0, AAnswers.Length) select AAnswers[n].isCorrect).ToArray();
            return new Tuple<string, uint, string[], bool[]>(text, points, answers, isCorrect);
        }
    }
}
