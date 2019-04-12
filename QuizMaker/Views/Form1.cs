using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QuizMaker
{
    public partial class Form1 : Form
    {
        Quiz quiz;
        public Form1()
        {
            InitializeComponent();
            quiz = new Quiz();
            quiz.title = "quizzzz";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.text = textBox1.Text;
            q.answers.Add(textBox2.Text);
            q.answers.Add(textBox3.Text);
            q.answers.Add(textBox4.Text);
            q.answers.Add(textBox5.Text);

            q.isCorrect.Add(checkBox1.Checked);
            q.isCorrect.Add(checkBox2.Checked);
            q.isCorrect.Add(checkBox3.Checked);
            q.isCorrect.Add(checkBox4.Checked);

            quiz.questions.Add(q);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(quiz);
            //Console.WriteLine(output);
            var o = JsonConvert.DeserializeObject(output);
            Console.Write(o.ToString());
        }
    }
}
