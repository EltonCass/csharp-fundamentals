using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Exceptions
{
    public class NotIntException : FormatException
    {
        public NotIntException() : base("The input provided is not an integer.") { }

        public NotIntException(string message) : base(message) { }

        public NotIntException(string message, Exception? innerException) : base(message, innerException) { }
    }
}
