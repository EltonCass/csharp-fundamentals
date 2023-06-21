using QuizzApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Models
{
    public record QuestionFillBlank : IEntity, IQuestion
    {
        public int Id { get; set; }
        public string Content { get; init; }
        public int Score { get; set; }
        public string CorrectAnswer { get; init; }
        public int BlankPosition { get; set; }

        public QuestionFillBlank(string content, int score, string correctAnswer, int blankPos)
        {
            Content = content;
            Score = score;
            CorrectAnswer = correctAnswer;
            BlankPosition = blankPos;
        }

        public void PrintQuestion()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("* "+Content);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Please, type your answer");
            Console.ResetColor();
        }
    }
}
