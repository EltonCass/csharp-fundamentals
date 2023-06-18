using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    internal class Question
    {
        public string Text { get; set; }
        public List<string> AnswerChoices { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string text, List<string> answerChoices, string correctAnswer)
        {
            Text = text;
            AnswerChoices = answerChoices;
            CorrectAnswer = correctAnswer;
        }

        public override string ToString()
        {
            string answerChoices = string.Join(", ", AnswerChoices);
            return  $"Question: {Text}\nAnswer Choices: {answerChoices}\nCorrect Answer: {CorrectAnswer}";
        }
    }
}
