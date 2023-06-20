using QuizzApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Models
{
    public class Quizz : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public HashSet<IQuestion>? Questions { get; set; }
        public HashSet<Category>? Categories { get; set; }

        public Quizz() { }
        public Quizz(string? name, string? desc, HashSet<IQuestion>? questions, HashSet<Category>? categories)
        {
            Name = name;
            Description = desc;
            Questions = questions;
            Categories = categories;
        }
    }
}
