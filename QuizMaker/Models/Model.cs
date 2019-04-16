﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace QuizMaker
{
    class Model
    {
        private Quiz quiz;
        public uint TotalPoints
        {
            get
            {
                return quiz.totalPoints;
            }
        }
        public string QuizTitle
        {
            get
            {
                return quiz.title;
            }
            set
            {
                quiz.title = value;
            }
        }
        public Model()
        {
            quiz = new Quiz();
        }


        public List<Tuple<string, uint, string[], bool[]>> GetQuestions
        {
            get
            {
                return quiz.GetQuestionTuples();
            }
        }
        public void AddQuestion(string text, string[] answers, bool[] isCorrect, uint points)
        {
            quiz.questions.Add(new Question(text, answers, isCorrect, points));
            quiz.totalPoints += points;
        }
        public void EditQuestion(int index, string text, string[] answers, bool[] isCorrect, uint points)
        {
            quiz.totalPoints -= quiz.questions[index].points;
            quiz.questions[index].Update(text, answers, isCorrect, points);
            quiz.totalPoints += points;
        }
        public void DeleteQuestion(int index)
        {
            if (index != -1)
            {
                quiz.totalPoints -= quiz.questions[index].points;
                quiz.questions.RemoveAt(index);
            }
        }
        public Tuple<string, uint, string[], bool[]> GetSelectedQuestion(int index)
        {
            return quiz.questions[index].GetTuple();
        }
        public void SaveQuiz(string path)
        {
            string outputJson = JsonConvert.SerializeObject(quiz);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path)))
            {
                outputFile.Write(outputJson);
            }
        }
    }
}
