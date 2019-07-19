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

        public Question() { }
        public Question(string text, List<Answer> answers, uint points)
        {
            this.answers = new Answer[answers.Count];
            for(int i = 0; i < answers.Count; i++)
            {
                this.answers[i] = new Answer(answers[i].text, answers[i].isCorrect);
            }
            this.text = text;
            this.points = points;
        }
        public void Update(string text, List<Answer> answers, uint points)
        {
            this.answers = new Answer[answers.Count];
            for (int i = 0; i < answers.Count; i++)
            {
                this.answers[i] = new Answer(answers[i].text, answers[i].isCorrect);
            }
            this.text = text;
            this.points = points;
        }
        public override string ToString()
        {
            return $"{text} {points}";
        }
    }
}
