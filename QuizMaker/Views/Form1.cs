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
        public Question[] Questions
        {
            set
            {
                int index = 0;
                treeView1.Nodes.Clear();
                foreach(Question q in value)
                {
                    Console.WriteLine("siema");
                    treeView1.Nodes.Add($"{index+1}. {q.text} - {q.points}pts");
                    for(int j = 0; j < q.answers.Length; j++)
                    {
                        treeView1.Nodes[index].Nodes.Add($"{q.answers[j]} - {q.isCorrect[j]}");
                    }
                    index += 1;
                }
            }
        }
        public string[] Answers
        {
            get
            {
                List<string> answers = new List<string>();
                foreach (AnswerControl c in flowLayoutAnswers.Controls)
                {
                    if (c.Text != "")
                    {
                        answers.Add(c.Text);
                    }
                }
                return answers.ToArray();
            }
            set
            {
                AnswerControl handle;
                for (int i = flowLayoutAnswers.Controls.Count; i < value.Length; i++)
                {
                    AnswerControl answer = new AnswerControl();
                    flowLayoutAnswers.Controls.Add(answer);
                }
                for(int i = 0; i < value.Length; i++)
                {
                    handle = (AnswerControl)flowLayoutAnswers.Controls[i];
                    handle.Text = value[i];
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
                    if (c.Text != "")
                    {
                        isCorrect.Add(c.IsCorrect);
                    }
                }
                return isCorrect.ToArray();
            }
            set
            {
                AnswerControl handle;
                for(int i = flowLayoutAnswers.Controls.Count ; i < value.Length; i++)
                {
                    AnswerControl answer = new AnswerControl();
                    flowLayoutAnswers.Controls.Add(answer);
                }
                for (int i = 0; i < value.Length; i++)
                {
                    handle = (AnswerControl)flowLayoutAnswers.Controls[i];
                    handle.IsCorrect = value[i];
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
        public event Action<int> EditQuestion;
        public event Action<int> DeleteQuestion;
        public event Action SaveQuiz;
        public event Action LoadQuiz;
        public void ShowMessage(string messageText)
        {
            MessageBox.Show(messageText);
        }

        #endregion
        int SelectedNodeIndex
        {
            get
            {
                try
                {
                    return treeView1.SelectedNode.Index;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            textBoxTotalPoints.Text = "0";
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
                EditQuestion(SelectedNodeIndex);
        }
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (DeleteQuestion != null)
                DeleteQuestion(SelectedNodeIndex);
        }
        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            AnswerControl answer = new AnswerControl();
            flowLayoutAnswers.Controls.Add(answer);
        }

    }
}
