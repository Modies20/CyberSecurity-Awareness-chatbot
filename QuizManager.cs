using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberSecurity_Awareness_Chatbot;

namespace CyberSecurity_Awareness_chatbot
{
    public class QuizManager
    {
        private List<QuizQuestion> questions;
        private int currentIndex;
        public int Score { get; private set; }

        public QuizManager()
        {
            questions = QuizData.GetQuestions();
            currentIndex = 0;
            Score = 0;
        }

        public QuizQuestion GetCurrentQuestion()
        {
            return questions[currentIndex];
        }

        public bool CheckAnswer(string selectedOption)
        {
            bool isCorrect = selectedOption == questions[currentIndex].CorrectOption;
            if (isCorrect) Score++;
            return isCorrect;
        }

        public bool HasNextQuestion()
        {
            return currentIndex < questions.Count - 1;
        }

        public void MoveToNext()
        {
            if (HasNextQuestion())
                currentIndex++;
        }

        public int TotalQuestions => questions.Count;
        public int CurrentQuestionIndex => currentIndex + 1;
    }
}
