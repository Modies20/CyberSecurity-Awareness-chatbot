using System.Collections.Generic;
using CyberSecurity_Awareness_chatbot;

namespace CyberSecurity_Awareness_Chatbot
{
    public static class QuizData
    {
        public static List<QuizQuestion> GetQuestions()
        {
            return new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    QuestionText = "What should you do if you receive an email asking for your password?",
                    OptionA = "Reply with your password",
                    OptionB = "Ignore the email",
                    OptionC = "Report the email as phishing",
                    OptionD = "Click the link to verify",
                    CorrectOption = "C"
                },
                new QuizQuestion
                {
                    QuestionText= "What makes a strong password?",
                    OptionA = "Your birthdate",
                    OptionB = "12345678",
                    OptionC = "A mix of letters, numbers, and symbols",
                    OptionD = "Your pet's name",
                    CorrectOption = "C"
                },
                new QuizQuestion
                {
                    QuestionText= "Which of the following is a form of social engineering?",
                    OptionA = "Using antivirus software",
                    OptionB = "Asking for help on a forum",
                    OptionC = "Phishing emails pretending to be your boss",
                    OptionD = "Installing updates",
                    CorrectOption = "C"
                },
                new QuizQuestion
                {
                    QuestionText = "How can you verify if a website is secure?",
                    OptionA = "It loads quickly",
                    OptionB = "It has 'https://' and a padlock icon",
                    OptionC = "It looks professional",
                    OptionD = "It has a colorful design",
                    CorrectOption = "B"
                },
                new QuizQuestion
                {
                    QuestionText= "What is phishing?",
                    OptionA = "Catching real fish",
                    OptionB = "Hacking a system physically",
                    OptionC = "Tricking users into giving personal info",
                    OptionD = "Fixing system bugs",
                    CorrectOption = "C"
                },
                new QuizQuestion
                {
                    QuestionText= "What should you do before clicking a link in an email?",
                    OptionA = "Hover to preview the link",
                    OptionB = "Click immediately",
                    OptionC = "Forward it to friends",
                    OptionD = "Ignore all emails",
                    CorrectOption = "A"
                },
                new QuizQuestion
                {
                    QuestionText= "What does 2FA stand for?",
                    OptionA = "Two-Factor Authentication",
                    OptionB = "Two-Face Algorithm",
                    OptionC = "Fast Access",
                    OptionD = "Free Access",
                    CorrectOption = "A"
                },
                new QuizQuestion
                {
                    QuestionText = "Why is it unsafe to use public Wi-Fi without a VPN?",
                    OptionA = "It’s too slow",
                    OptionB = "You might get a virus",
                    OptionC = "Your data can be intercepted",
                    OptionD = "It drains battery faster",
                    CorrectOption = "C"
                },
                new QuizQuestion
                {
                    QuestionText = "Which one is the safest method to store passwords?",
                    OptionA = "Write on paper",
                    OptionB = "Use a password manager",
                    OptionC = "Text to yourself",
                    OptionD = "Use same password everywhere",
                    CorrectOption = "B"
                },
                new QuizQuestion
                {
                    QuestionText= "Which is an example of a safe browsing habit?",
                    OptionA = "Clicking every pop-up",
                    OptionB = "Sharing passwords with friends",
                    OptionC = "Only visiting trusted websites",
                    OptionD = "Installing every toolbar offered",
                    CorrectOption = "C"
                }
            };
        }
    }
}