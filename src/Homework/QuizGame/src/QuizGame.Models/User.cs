using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string Score { get; set; }
        public EmailAddressAttribute Email { get; set; }

        public User(string name, string score, EmailAddressAttribute email,)
        {
            Name = name;
            Score = score;
            Email = email;
        }

        public override string ToString()
        {
            return $"Username: {Name}\nScore: {Score}\nEmail: {Email}";
        }
    }
}
