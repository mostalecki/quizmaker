namespace QuizMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxAddQuestion = new System.Windows.Forms.GroupBox();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.flowLayoutAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTotalPoints = new System.Windows.Forms.Label();
            this.textBoxTotalPoints = new System.Windows.Forms.TextBox();
            this.answerControl1 = new QuizMaker.AnswerControl();
            this.answerControl2 = new QuizMaker.AnswerControl();
            this.answerControl3 = new QuizMaker.AnswerControl();
            this.answerControl4 = new QuizMaker.AnswerControl();
            this.groupBoxAddQuestion.SuspendLayout();
            this.flowLayoutAnswers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(149, 258);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(75, 44);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(0, 19);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(194, 20);
            this.textBoxQuestion.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save quiz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxAddQuestion
            // 
            this.groupBoxAddQuestion.Controls.Add(this.btnAddAnswer);
            this.groupBoxAddQuestion.Controls.Add(this.flowLayoutAnswers);
            this.groupBoxAddQuestion.Controls.Add(this.label1);
            this.groupBoxAddQuestion.Controls.Add(this.numericUpDownPoints);
            this.groupBoxAddQuestion.Controls.Add(this.label2);
            this.groupBoxAddQuestion.Controls.Add(this.btnAddQuestion);
            this.groupBoxAddQuestion.Controls.Add(this.textBoxQuestion);
            this.groupBoxAddQuestion.Location = new System.Drawing.Point(267, 71);
            this.groupBoxAddQuestion.Name = "groupBoxAddQuestion";
            this.groupBoxAddQuestion.Size = new System.Drawing.Size(230, 308);
            this.groupBoxAddQuestion.TabIndex = 11;
            this.groupBoxAddQuestion.TabStop = false;
            this.groupBoxAddQuestion.Text = "Add question";
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(174, 60);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(22, 23);
            this.btnAddAnswer.TabIndex = 13;
            this.btnAddAnswer.Text = "+";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // flowLayoutAnswers
            // 
            this.flowLayoutAnswers.AutoScroll = true;
            this.flowLayoutAnswers.Controls.Add(this.answerControl1);
            this.flowLayoutAnswers.Controls.Add(this.answerControl2);
            this.flowLayoutAnswers.Controls.Add(this.answerControl3);
            this.flowLayoutAnswers.Controls.Add(this.answerControl4);
            this.flowLayoutAnswers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutAnswers.Location = new System.Drawing.Point(6, 86);
            this.flowLayoutAnswers.Name = "flowLayoutAnswers";
            this.flowLayoutAnswers.Size = new System.Drawing.Size(218, 150);
            this.flowLayoutAnswers.TabIndex = 14;
            this.flowLayoutAnswers.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Points:";
            // 
            // numericUpDownPoints
            // 
            this.numericUpDownPoints.Location = new System.Drawing.Point(42, 45);
            this.numericUpDownPoints.Name = "numericUpDownPoints";
            this.numericUpDownPoints.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownPoints.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Answers:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(86, 5);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 12;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(18, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(50, 13);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Quiz title:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(119, 356);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load quiz";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 255);
            this.treeView1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 268);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Questions";
            // 
            // labelTotalPoints
            // 
            this.labelTotalPoints.AutoSize = true;
            this.labelTotalPoints.Location = new System.Drawing.Point(18, 38);
            this.labelTotalPoints.Name = "labelTotalPoints";
            this.labelTotalPoints.Size = new System.Drawing.Size(65, 13);
            this.labelTotalPoints.TabIndex = 17;
            this.labelTotalPoints.Text = "Total points:";
            // 
            // textBoxTotalPoints
            // 
            this.textBoxTotalPoints.Location = new System.Drawing.Point(86, 31);
            this.textBoxTotalPoints.Name = "textBoxTotalPoints";
            this.textBoxTotalPoints.ReadOnly = true;
            this.textBoxTotalPoints.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalPoints.TabIndex = 18;
            // 
            // answerControl1
            // 
            this.answerControl1.IsCorrect = false;
            this.answerControl1.Location = new System.Drawing.Point(3, 3);
            this.answerControl1.Name = "answerControl1";
            this.answerControl1.Size = new System.Drawing.Size(187, 29);
            this.answerControl1.TabIndex = 0;
            // 
            // answerControl2
            // 
            this.answerControl2.IsCorrect = false;
            this.answerControl2.Location = new System.Drawing.Point(3, 38);
            this.answerControl2.Name = "answerControl2";
            this.answerControl2.Size = new System.Drawing.Size(187, 29);
            this.answerControl2.TabIndex = 1;
            // 
            // answerControl3
            // 
            this.answerControl3.IsCorrect = false;
            this.answerControl3.Location = new System.Drawing.Point(3, 73);
            this.answerControl3.Name = "answerControl3";
            this.answerControl3.Size = new System.Drawing.Size(187, 29);
            this.answerControl3.TabIndex = 2;
            // 
            // answerControl4
            // 
            this.answerControl4.IsCorrect = false;
            this.answerControl4.Location = new System.Drawing.Point(3, 108);
            this.answerControl4.Name = "answerControl4";
            this.answerControl4.Size = new System.Drawing.Size(187, 29);
            this.answerControl4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(512, 413);
            this.Controls.Add(this.textBoxTotalPoints);
            this.Controls.Add(this.labelTotalPoints);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.groupBoxAddQuestion);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "QuizMaker";
            this.groupBoxAddQuestion.ResumeLayout(false);
            this.groupBoxAddQuestion.PerformLayout();
            this.flowLayoutAnswers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxAddQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTotalPoints;
        private System.Windows.Forms.TextBox textBoxTotalPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPoints;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAnswers;
        private AnswerControl answerControl1;
        private AnswerControl answerControl2;
        private AnswerControl answerControl3;
        private AnswerControl answerControl4;
    }
}

