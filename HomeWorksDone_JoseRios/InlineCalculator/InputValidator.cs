using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace init
{
    public class InputValidator
    {
        public static string InputWithoutNull()
        {
            string? input = Console.ReadLine();
            while (true)
            {
                if (!string.IsNullOrEmpty(input))
                    return input;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a value");
                    Console.ResetColor();
                    input = Console.ReadLine();
                }
            }
        }

        public static string RemoveLetterFromAritmeticExpression(string input)
        {
            var regex = new Regex(@"[a-zA-Z\s\?']");
            while (true)
            {
                if (regex.IsMatch(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid value without letters or spaces");
                    Console.ResetColor();
                    input = InputWithoutNull();
                }
                else
                    return input;
            }
        }
    }
}
