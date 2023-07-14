using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    internal class Collection
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int TotalScore { get; set; }
        public List<Quiz> Quizzes { get; set; }

        public Collection(string name, string description, Category category, List<Quiz> quizzes)
        {
            Name = name;
            Description = description;
            Category = category;
            Quizzes = quizzes;
        }
    }
}
