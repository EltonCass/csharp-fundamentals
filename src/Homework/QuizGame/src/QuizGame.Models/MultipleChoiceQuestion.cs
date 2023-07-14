using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    internal record MultipleChoiceQuestion : Question
    {
        public List<string> AnswerChoices { get; set; }

        public MultipleChoiceQuestion(string text, string correctAnswer, int points, List<string> answerChoices) : base(text, correctAnswer, points)
        {
            AnswerChoices = answerChoices;
        }

        public override string ToString()
        {
            string answerChoices = string.Join("\n  • ", AnswerChoices);
            return $"Question: {Text}\nCorrect Answer: {CorrectAnswer}\nPoints: {Points}\nAnswer Choices:\n";
        }
    }
}
