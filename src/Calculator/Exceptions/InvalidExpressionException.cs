using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Exceptions
{
    public class InvalidExpressionException : ArgumentException
    {
        public InvalidExpressionException() : base("The input provided does not match the requirements.") { }

        public InvalidExpressionException(string message) : base(message) { }

        public InvalidExpressionException(string message, Exception? innerException) : base(message, innerException) { }
    }
}
