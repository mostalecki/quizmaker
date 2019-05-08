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
        public List<Tuple<string, uint, List<Tuple<string, bool>>>> Questions
        {
            set
            {
                int index = 0;
                treeView1.Nodes.Clear();
                foreach (var questionTuple in value)
                {
                    treeView1.Nodes.Add($"{index + 1}. {questionTuple.Item1} - {questionTuple.Item2}pts");
                    for (int i = 0; i < questionTuple.Item3.Count; i++)
                    {
                        treeView1.Nodes[index].Nodes.Add($"{questionTuple.Item3[i].Item1} - {questionTuple.Item3[i].Item2}");
                    }
                    index += 1;
                }
                treeView1.Nodes.Add("+ New question");
            }
        }
        public List<Tuple<string, bool>> Answers
        {
            get
            {
                List<Tuple<string, bool>> answers = new List<Tuple<string, bool>>();
                foreach (AnswerControl c in flowLayoutAnswers.Controls)
                {
                    if (c.Text != "")
                    {
                        answers.Add(new Tuple<string, bool>(c.Text, c.IsCorrect));
                    }
                }
                return answers;
            }
            set
            {
                AnswerControl handle;
                flowLayoutAnswers.Controls.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    AnswerControl answer = new AnswerControl();
                    flowLayoutAnswers.Controls.Add(answer);
                }
                for (int i = 0; i < value.Count; i++)
                {
                    handle = (AnswerControl)flowLayoutAnswers.Controls[i];
                    handle.Text = value[i].Item1;
                    handle.IsCorrect = value[i].Item2;
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
                for (int i = flowLayoutAnswers.Controls.Count; i < value.Length; i++)
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
        public event Action<int> SelectQuestion;
        public event Action<string> SaveQuiz;
        public event Action<string> LoadQuiz;
        public event Action PostQuiz;
        public void ShowMessage(string messageText)
        {
            MessageBox.Show(messageText);
        }
        public void ClearEntries()
        {
            Question = "";
            Points = 1;
            flowLayoutAnswers.Controls.Clear();
            for (int i = 0; i < 4; i++)
            {
                AnswerControl answer = new AnswerControl();
                flowLayoutAnswers.Controls.Add(answer);
            }

        }

        #endregion
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            textBoxTotalPoints.Text = "0";
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
        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            AnswerControl answer = new AnswerControl();
            flowLayoutAnswers.Controls.Add(answer);
        }
        private bool validateQuestionFields()
        {
            if (Question == "")
            {
                MessageBox.Show("Question text cannot be blank.");
                return false;
            }
            else if (Answers.Count < 2)
            {
                MessageBox.Show("Add at least 2 answers.");
                return false;
            }
            return true;

        }
        #region EventMethods
        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.FileName = "unnamed_quiz.json";
                saveFileDialog.Filter = "JSON files (*.json)|*.json|Text files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (SaveQuiz != null)
                        SaveQuiz(saveFileDialog.FileName);
                }
            }
        }
        private void btnPostQuiz_Click(object sender, EventArgs e)
        {
                    if (PostQuiz != null)
                        PostQuiz();
        }

        private void btnLoadQuiz_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "JSON files (*.json)|*.json|Txt files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (LoadQuiz != null)
                        LoadQuiz(openFileDialog.FileName);
                }
            }
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (validateQuestionFields())
            {
                if (AddQuestion != null)
                    AddQuestion();
            }
        }
        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (SelectedNodeIndex + 1 == treeView1.Nodes.Count || SelectedNodeIndex == -1)
            {
                return;
            }
            if (validateQuestionFields())
            {
                if (EditQuestion != null)
                    EditQuestion(SelectedNodeIndex);
            }
        }
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (SelectedNodeIndex + 1 == treeView1.Nodes.Count || SelectedNodeIndex == -1)
            {
                return;
            }
            if (DeleteQuestion != null)
                DeleteQuestion(SelectedNodeIndex);
        }
        private void QuestionListClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                foreach (TreeNode node in treeView1.Nodes)
                {
                    node.BackColor = Color.White;
                    node.ForeColor = Color.Black;
                }
                e.Node.BackColor = SystemColors.MenuHighlight;
                e.Node.ForeColor = Color.White;

                if (e.Node.Index + 1 == treeView1.Nodes.Count)
                {
                    ClearEntries();
                    return;
                }

                if (SelectQuestion != null)
                    SelectQuestion(e.Node.Index);
            }
            else
            {
                //todo: if sender is a chld node, unselect or make child nodes entirely unselectable to keep questions treeView clear
            }
        }
        #endregion
    }
}
