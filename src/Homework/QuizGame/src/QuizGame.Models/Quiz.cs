using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    internal class Quiz
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public HashSet<string> Categories { get; set; }
        public List<Question> Questions { get; set; }

        public Quiz(string name, string description, HashSet<string> categories, List<Question> questions)
        {
            Name = name;
            Description = description;
            Categories = categories;
            Questions = questions;
        }

        public override string ToString()
        {
            string categories = string.Join(", ", Categories);
            string questions = string.Join("\n  • ", Questions);
            return $"Quiz Name: {Name}\nDescription: {Description}\nCategories: {categories}\nQuestions:\n  • {questions}";
        }
    }
}
