using QuizzApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Models
{
    public record QuizzCollection : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Quizz>? Quizzes { get; set; }
        
        public QuizzCollection() { }
        public QuizzCollection(string? name, string? desc, List<Quizz>? qzz)
        {
            Name = name;
            Description = desc;
            Quizzes = qzz ?? new List<Quizz>();
        }
    }
}
