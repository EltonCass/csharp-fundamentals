using QuizzApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Models
{
    public record QuestionMultipleChoice : IEntity, IQuestion
    {
        public int Id { get; set; }
        public string Content { get; init; }
        public int Score { get; set; }
        public string CorrectAnswer { get; init; }
        public string[] Choices { get; set; } = new string[4];
        public readonly Dictionary<string, string> MultipleAnswersMap = new Dictionary<string, string>();
        private Dictionary<int, string> _ADMap = new Dictionary<int, string>
        { 
            {0, "A) " },
            {1, "B) " },
            {2, "C) " },
            {3, "D) " }
        };

        public QuestionMultipleChoice(string content, int score, string correctAnswer, string[] choices)
        {
            Content = content;
            Score = score;
            CorrectAnswer = correctAnswer;
            Choices = choices;

            for(int i = 0; i<choices.Length; i++)
                MultipleAnswersMap.Add(_ADMap[i][0].ToString().ToLower(), choices[i].ToLower());
        }

        public void PrintQuestion()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("* "+Content);
            Console.ResetColor();
            for(var  i = 0; i < Choices.Count(); i++)
                Console.WriteLine($"{_ADMap[i]} {Choices[i]}");
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Please, write your answer [A, B, C, or D]");
            Console.ResetColor();
        }
    }
}
