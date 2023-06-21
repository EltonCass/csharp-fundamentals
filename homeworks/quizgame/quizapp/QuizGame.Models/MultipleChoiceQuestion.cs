using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    public class MultipleChoiceQuestion : Question
    {
        public List<string> Choices = new List<string>();
        public readonly Dictionary<string, string> MultipleAnswersMap = new Dictionary<string, string>();
        private Dictionary<int, string> _ADMap = new Dictionary<int, string>
        {
            {0, "A) " },
            {1, "B) " },
            {2, "C) " },
            {3, "D) " }
        };

        public MultipleChoiceQuestion(string text, int score, string correctAnswer, List<String> choices) : base(text, score, correctAnswer)
        {
            Text = text;
            Score = score;
            CorrectAnswer = correctAnswer;
            Choices = choices;

            for (int i = 0; i < choices.Count; i++)
                MultipleAnswersMap.Add(_ADMap[i][0].ToString().ToLower(), choices[i].ToLower());
        }

        public void PrintQuestion()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("* " + Text);
            Console.ResetColor();
            for (var i = 0; i < Choices.Count(); i++)
                Console.WriteLine($"{_ADMap[i]} {Choices[i]}");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Please, write your answer [A, B, C, or D]");
            Console.ResetColor();
        }
    }
}
