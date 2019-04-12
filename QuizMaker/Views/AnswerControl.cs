using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class AnswerControl : UserControl
    {
        public string Text
        {
            get
            {
                return textBoxAnswer.Text;
            }
            set
            {
                textBoxAnswer.Text = value;
            }
        }
        public bool IsCorrect
        {
            get
            {
                return checkBoxIsCorrect.Checked;
            }
            set
            {
                checkBoxIsCorrect.Checked = value;
            }
        }
        public AnswerControl()
        {
            InitializeComponent();
        }
    }
}
