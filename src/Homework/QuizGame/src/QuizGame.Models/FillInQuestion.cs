using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    internal record FillInQuestion : Question
    {
        public int BlankPosition { get; set; }

        public FillInQuestion(string text, string correctAnswer, int points, int blankPosition) : base(text, correctAnswer, points)
        {
            BlankPosition = blankPosition;
        }
    }
}
