namespace QuizMaker
{
    partial class AnswerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.checkBoxIsCorrect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(3, 3);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(160, 20);
            this.textBoxAnswer.TabIndex = 0;
            // 
            // checkBoxIsCorrect
            // 
            this.checkBoxIsCorrect.AutoSize = true;
            this.checkBoxIsCorrect.Location = new System.Drawing.Point(169, 6);
            this.checkBoxIsCorrect.Name = "checkBoxIsCorrect";
            this.checkBoxIsCorrect.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsCorrect.TabIndex = 1;
            this.checkBoxIsCorrect.UseVisualStyleBackColor = true;
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxIsCorrect);
            this.Controls.Add(this.textBoxAnswer);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(187, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.CheckBox checkBoxIsCorrect;
    }
}
