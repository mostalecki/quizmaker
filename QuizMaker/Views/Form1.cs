using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class Form1 : Form, IView
    {
        #region IView
        public string QuizTitle
        {
            get
            {
                return textBoxTitle.Text;
            }
            set
            {
                textBoxTitle.Text = value;
            }
        }
        public string Question
        {
            get
            {
                return textBoxQuestion.Text;
            }
            set
            {
                textBoxQuestion.Text = value;
            }
        }
        public string[] Answers
        {
            get
            {
                List<string> answers = new List<string>();
                foreach (AnswerControl c in flowLayoutAnswers.Controls)
                {
                    answers.Add(c.Text);
                }
                return answers.ToArray();
            }
            set
            {
                for (int i = flowLayoutAnswers.Controls.Count; i < value.Length; i++)
                {
                    AnswerControl answer = new AnswerControl();
                    flowLayoutAnswers.Controls.Add(answer);
                }
                for(int i = 0; i < value.Length; i++)
                {
                    flowLayoutAnswers.Controls[i].Text = value[i];
                }
            }
        }
        public bool[] IsCorrect
        {
            get
            {
                List<bool> isCorrect = new List<bool>();
                foreach (AnswerControl c in flowLayoutAnswers.Controls)
                {
                    isCorrect.Add(c.IsCorrect);
                }
                return isCorrect.ToArray();
            }
            set
            {
                for(int i = flowLayoutAnswers.Controls.Count ; i < value.Length; i++)
                {
                    AnswerControl answer = new AnswerControl();
                    flowLayoutAnswers.Controls.Add(answer);
                }
                for (int i = 0; i < value.Length; i++)
                {
                    flowLayoutAnswers.Controls[i].Text = value[i];
                }
            }
        }
        public uint Points
        {
            get
            {
                return (uint)numericUpDownPoints.Value;
            }
            set
            {
                numericUpDownPoints.Value = (decimal)value;
            }
        }
        public uint TotalPoints
        {
            set
            {
                textBoxTotalPoints.Text = value.ToString();
            }
        }
        public event Action AddQuestion;
        public event Action EditQuestion;
        public event Action DeleteQuestion;
        public event Action SaveQuiz;
        public event Action LoadQuiz;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            if (SaveQuiz != null)
                SaveQuiz();
        }

        private void btnLoadQuiz_Click(object sender, EventArgs e)
        {
            if (LoadQuiz != null)
                LoadQuiz();
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (AddQuestion != null)
                AddQuestion();
        }
        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (EditQuestion != null)
                EditQuestion();
        }
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (DeleteQuestion != null)
                DeleteQuestion();
        }
        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            AnswerControl answer = new AnswerControl();
            flowLayoutAnswers.Controls.Add(answer);
        }

    }
}
