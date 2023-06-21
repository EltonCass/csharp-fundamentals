using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace QuizGame.Models
{
    public class FillBlankQuestion : Question
    {
        public int BlankPosition { get; set; }

        public FillBlankQuestion(string text, int score, string correctAnswer, int blankPosition) : base(text, score, correctAnswer)
        {
            Text = text;
            Score = score;
            CorrectAnswer = correctAnswer;
            BlankPosition = blankPosition;
        }

        public void PrintQuestion()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("* " + Text);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Please, type your answer");
            Console.ResetColor();
        }
    }
}
