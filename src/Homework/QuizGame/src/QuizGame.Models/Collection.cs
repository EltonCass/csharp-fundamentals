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
        public string Category { get; set; }
        public double TotalScore { get; set; }
        public List<Quiz> Quizzes { get; set; }

        public Collection(string name, string description, string category, List<Quiz> quizzes)
        {
            Name = name;
            Description = description;
            Category = category;
            Quizzes = quizzes;
        }
    }
}
