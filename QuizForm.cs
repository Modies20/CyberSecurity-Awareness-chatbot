using System;
using System.Windows.Forms;

namespace CyberSecurity_Awareness_chatbot
{
    public partial class QuizForm : Form
    {
        private QuizManager quizManager;

        public QuizForm()
        {
            InitializeComponent();
            quizManager = new QuizManager();
            LoadCurrentQuestion();
        }
        private void QuizForm_Load(object sender, EventArgs e)
        {
            LoadCurrentQuestion();
        }
        private void LoadCurrentQuestion()
        {
            var question = quizManager.GetCurrentQuestion();
            lblQuestion.Text = question.QuestionText;
            rbOptionA.Text = question.OptionA;
            rbOptionB.Text = question.OptionB;
            rbOptionC.Text = question.OptionC;
            rbOptionD.Text = question.OptionD;
            lblFeedback.Text = string.Empty;
            lblScore.Text = $"Score: {quizManager.Score}/{quizManager.TotalQuestions}";

            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            string selectedOption = GetSelectedOption();
            if (string.IsNullOrEmpty(selectedOption))
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            bool isCorrect = quizManager.CheckAnswer(selectedOption);
            lblFeedback.Text = isCorrect ? "Correct!" : "Incorrect!";
            lblScore.Text = $"Score: {quizManager.Score}/{quizManager.TotalQuestions}";
            btnSubmitAnswer.Enabled = false;
        }

        private string GetSelectedOption()
        {
            if (rbOptionA.Checked) return "A";
            if (rbOptionB.Checked) return "B";
            if (rbOptionC.Checked) return "C";
            if (rbOptionD.Checked) return "D";
            return null;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (quizManager.HasNextQuestion())
            {
                quizManager.MoveToNext();
                LoadCurrentQuestion();
                btnSubmitAnswer.Enabled = true;
            }
            else
            {
                MessageBox.Show("You've completed the quiz!");
                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = false;
            }
        }

        private void btnExitQuiz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitAnswer_Click_1(object sender, EventArgs e)
        {
            string selectedOption = GetSelectedOption();
            if (string.IsNullOrEmpty(selectedOption))
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            bool isCorrect = quizManager.CheckAnswer(selectedOption);
            lblFeedback.Text = isCorrect ? "Correct!" : "Incorrect!";
            lblScore.Text = $"Score: {quizManager.Score}/{quizManager.TotalQuestions}";
            btnSubmitAnswer.Enabled = false;
        }

        private void btnNextQuestion_Click_1(object sender, EventArgs e)
        {
            if (quizManager.HasNextQuestion())
            {
                quizManager.MoveToNext();
                LoadCurrentQuestion();
                btnSubmitAnswer.Enabled = true;
            }
            else
            {
                MessageBox.Show("You've completed the quiz!");
                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = false;
            }

        }

        private void btnExitQuiz_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
