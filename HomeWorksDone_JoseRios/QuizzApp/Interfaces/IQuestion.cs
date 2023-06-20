using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Interfaces
{
    public interface IQuestion
    {
        public string? Content { get; set; }
        public int Score { get; set; }
        public string? CorrectAnswer { get; set; }
    }
}
