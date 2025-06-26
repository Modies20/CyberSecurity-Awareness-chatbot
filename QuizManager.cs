using System;
using System.Collections.Generic;
using CyberSecurity_Awareness_Chatbot;

namespace CyberSecurity_Awareness_chatbot
{
    public class QuizManager
    {
        private readonly List<QuizQuestion> _questions;
        private int _currentIndex;

        public int Score { get; private set; }
        public int TotalQuestions => _questions.Count;
        public int CurrentQuestionIndex => _currentIndex + 1;
        public bool IsQuizCompleted => _currentIndex >= _questions.Count;

        public QuizManager()
        {
            _questions = QuizData.GetQuestions() ?? new List<QuizQuestion>();
            _currentIndex = 0;
            Score = 0;
        }

        public QuizQuestion GetCurrentQuestion()
        {
            if (!IsQuizCompleted)
                return _questions[_currentIndex];
            else
                return null;
        }

        public bool CheckAnswer(string selectedOption)
        {
            if (IsQuizCompleted) return false;

            bool isCorrect = string.Equals(
                selectedOption,
                _questions[_currentIndex].CorrectOption,
                StringComparison.OrdinalIgnoreCase
            );

            if (isCorrect) Score++;
            return isCorrect;
        }

        public bool HasNextQuestion()
        {
            return _currentIndex < _questions.Count - 1;
        }

        public void MoveToNext()
        {
            if (HasNextQuestion())
                _currentIndex++;
        }
    }
}
