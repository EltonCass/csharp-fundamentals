using QuizzApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Models
{
    public record Question_MultipleChoise : IEntity, IQuestion
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public int Score { get; set; }
        public string? CorrectAnswer { get; set; }
        public string[]? Choices { get; set; } = new string[4];

        public Question_MultipleChoise() { }
        public Question_MultipleChoise(string? content, int score, string? correctAnswer, string[]? choices)
        {
            Content = content;
            Score = score;
            CorrectAnswer = correctAnswer;
            Choices = choices;
        }
    }
}
