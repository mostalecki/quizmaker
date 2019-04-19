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
        public Answer[] answers;
        public uint points;

        public Question(string text, List<Tuple<string, bool>> answers, uint points)
        {
            this.answers = new Answer[answers.Count];
            for(int i = 0; i < answers.Count; i++)
            {
                this.answers[i] = new Answer(answers[i].Item1, answers[i].Item2);
            }
            this.text = text;
            this.points = points;
        }
        public void Update(string text, List<Tuple<string, bool>> answers, uint points)
        {
            this.answers = new Answer[answers.Count];
            for (int i = 0; i < answers.Count; i++)
            {
                this.answers[i] = new Answer(answers[i].Item1, answers[i].Item2);
            }
            this.text = text;
            this.points = points;
        }
        public override string ToString()
        {
            return $"{text} {points}";
        }
        public Tuple<string, uint, List<Tuple<string, bool>> > GetTuple()
        {
            //string[] answersTxt = (from n in Enumerable.Range(0, answers.Length) select answers[n].text).ToArray();
            //bool[] isCorrect = (from n in Enumerable.Range(0, answers.Length) select answers[n].isCorrect).ToArray();
            List<Tuple<string, bool>> answersTuples = (from n in Enumerable.Range(0, answers.Length) select new Tuple<string, bool>(answers[n].text, answers[n].isCorrect)).ToList();
            return new Tuple<string, uint, List<Tuple<string, bool>> >(text, points, answersTuples);
        }
    }
}
