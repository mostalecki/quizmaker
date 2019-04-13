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
        //TODO: create getters and setters for Answers and IsCorrect
        public string[] Answers { get; set; }
        public bool[] IsCorrect { get; set; }
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


        }

        private void btnLoadQuiz_Click(object sender, EventArgs e)
        {
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            AnswerControl answer = new AnswerControl();
            flowLayoutAnswers.Controls.Add(answer);
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {

        }
        private void btnEditQuestion_Click(object sender, EventArgs e)
        {

        }
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {

        }

    }
}
