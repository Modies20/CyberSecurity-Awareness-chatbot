namespace CyberSecurity_Awareness_chatbot
{
    partial class QuizForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.rbOptionC = new System.Windows.Forms.RadioButton();
            this.rbOptionD = new System.Windows.Forms.RadioButton();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnExitQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(99, 26);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(158, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question will appear here";
            // 
            // rbOptionA
            // 
            this.rbOptionA.AutoSize = true;
            this.rbOptionA.Location = new System.Drawing.Point(102, 75);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Size = new System.Drawing.Size(44, 20);
            this.rbOptionA.TabIndex = 1;
            this.rbOptionA.TabStop = true;
            this.rbOptionA.Text = "A) ";
            this.rbOptionA.UseVisualStyleBackColor = true;
            // 
            // rbOptionB
            // 
            this.rbOptionB.AutoSize = true;
            this.rbOptionB.Location = new System.Drawing.Point(102, 105);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Size = new System.Drawing.Size(41, 20);
            this.rbOptionB.TabIndex = 2;
            this.rbOptionB.TabStop = true;
            this.rbOptionB.Text = "B)";
            this.rbOptionB.UseVisualStyleBackColor = true;
            // 
            // rbOptionC
            // 
            this.rbOptionC.AutoSize = true;
            this.rbOptionC.Location = new System.Drawing.Point(102, 131);
            this.rbOptionC.Name = "rbOptionC";
            this.rbOptionC.Size = new System.Drawing.Size(41, 20);
            this.rbOptionC.TabIndex = 3;
            this.rbOptionC.TabStop = true;
            this.rbOptionC.Text = "C)";
            this.rbOptionC.UseVisualStyleBackColor = true;
            // 
            // rbOptionD
            // 
            this.rbOptionD.AutoSize = true;
            this.rbOptionD.Location = new System.Drawing.Point(102, 169);
            this.rbOptionD.Name = "rbOptionD";
            this.rbOptionD.Size = new System.Drawing.Size(42, 20);
            this.rbOptionD.TabIndex = 4;
            this.rbOptionD.TabStop = true;
            this.rbOptionD.Text = "D)";
            this.rbOptionD.UseVisualStyleBackColor = true;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(102, 211);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAnswer.TabIndex = 5;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(117, 267);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 16);
            this.lblFeedback.TabIndex = 6;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(406, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(67, 16);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 0/0";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(409, 75);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 8;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            // 
            // btnExitQuiz
            // 
            this.btnExitQuiz.Location = new System.Drawing.Point(409, 128);
            this.btnExitQuiz.Name = "btnExitQuiz";
            this.btnExitQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnExitQuiz.TabIndex = 9;
            this.btnExitQuiz.Text = "Exit";
            this.btnExitQuiz.UseVisualStyleBackColor = true;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitQuiz);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.rbOptionD);
            this.Controls.Add(this.rbOptionC);
            this.Controls.Add(this.rbOptionB);
            this.Controls.Add(this.rbOptionA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnExitQuiz;
    }
}