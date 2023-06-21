using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Interfaces
{
    public interface IQuestion
    {
        public string Content { get; init; }
        public int Score { get; set; }
        public string CorrectAnswer { get; init; }
        public void PrintQuestion();
    }
}
