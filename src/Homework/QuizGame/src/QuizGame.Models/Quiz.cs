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
        public HashSet<Category> Categories { get; set; }
        public List<Question> Questions { get; set; }
        public int Score { get; set; }

        public Quiz(string name, string description, HashSet<Category> categories, List<Question> questions)
        {
            Name = name;
            Description = description;
            Categories = categories;
            Questions = questions;
            Score = 0;
        }

        public override string ToString()
        {
            string categories = string.Join(", ", Categories);
            string questions = string.Join("\n  • ", Questions);
            return $"Quiz Name: {Name}\nDescription: {Description}\nCategories: {categories}\nQuestions:\n  • {questions}";
        }
    }
}
