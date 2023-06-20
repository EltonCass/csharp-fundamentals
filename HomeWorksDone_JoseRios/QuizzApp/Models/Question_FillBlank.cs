using QuizzApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Models
{
    public record Question_FillBlank : IEntity, IQuestion
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public int Score { get; set; }
        public string? CorrectAnswer { get; set; }
        public int BlankPosition { get; set; }

        public Question_FillBlank() { }
        public Question_FillBlank(string? content, int score, string? correctAnswer, int blankPos)
        {
            Content = content;
            Score = score;
            CorrectAnswer = correctAnswer;
            BlankPosition = blankPos;
        }
    }
}
