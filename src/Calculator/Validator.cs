using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Calculator.Exceptions;

namespace Calculator
{
    public class Validator
    {
        public Validator() { }

        public void ValidateExpression(string expression)
        {
            Regex pattern1 = new Regex(@"^[+\-]?\d");
            Regex pattern2 = new Regex(@"\d$");
            Regex pattern3 = new Regex(@"^[0-9.+*/-]*$");

            if (!(pattern1.IsMatch(expression) && pattern2.IsMatch(expression) && pattern3.IsMatch(expression)))
            {
                throw new InvalidExpressionException();
            }
        }
    }
}
