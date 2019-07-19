using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using System.Net.Http;


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

        public List<Question> GetQuestions
        {
            get
            {
                return quiz.questions;
            }
        }
        public void AddQuestion(string text, List<Answer> answers, uint points)
        {
            quiz.questions.Add(new Question(text, answers, points));
            quiz.totalPoints += points;
        }
        public void EditQuestion(int index, string text, List<Answer> answers, uint points)
        {
            quiz.totalPoints -= quiz.questions[index].points;
            quiz.questions[index].Update(text, answers, points);
            quiz.totalPoints += points;
        }
        public void DeleteQuestion(int index)
        {
            quiz.totalPoints -= quiz.questions[index].points;
            quiz.questions.RemoveAt(index);
        }
        public Question GetSelectedQuestion(int index)
        {
            return quiz.questions[index];
        }
        public void SaveQuiz(string path)
        {
            string json = new JavaScriptSerializer().Serialize(quiz);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path)))
            {
                outputFile.Write(json);
            }
        }
        public void LoadQuiz(string path)
        {
            string inputJson;
            using (StreamReader inputFile = new StreamReader(Path.Combine(path)))
            {
                inputJson = inputFile.ReadToEnd();
            }

            try
            {
                quiz = new JavaScriptSerializer().Deserialize<Quiz>(inputJson);
                
            }
            catch(Exception)
            {
                throw new Exception("Failed to open file");
            }
        }

        public async Task PostQuiz()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://stardustscarab.pythonanywhere.com/quizzes/create";
                try
                {

                    string json = new JavaScriptSerializer().Serialize(quiz);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(url, content);

                    if (result.IsSuccessStatusCode)
                    {
                        Console.WriteLine(result.StatusCode.ToString());
                    }
                    else
                    {
                        // problems handling here
                        Console.WriteLine(
                            "Error occurred, the status code is: {0}",
                            result.StatusCode
                        );
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
