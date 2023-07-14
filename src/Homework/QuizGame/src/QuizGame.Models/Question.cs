using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    internal record Question
    {
        public string Text { get; init; }
        public string CorrectAnswer { get; init; }
        public int Points { get; init; }

        public Question(string text ,string correctAnswer, int points)
        {
            Text = text;
            CorrectAnswer = correctAnswer;
            Points = points;
        }

        public override string ToString()
        {
            return  $"Question: {Text}\nCorrect Answer: {CorrectAnswer}<";
        }
    }
}
