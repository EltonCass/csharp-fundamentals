using QuizzApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using QuizzApp.FakeDB;
using QuizzApp.Controllers;

namespace QuizzApp.Helpers
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

        public static int VerifyNumberInSelectOptions(string input, int maxVal)
        {
            while (true)
            {
                try
                {
                    int selection = int.Parse(input);
                    if (selection > 0 && selection <= maxVal)
                        return selection;
                    else
                        throw new Exception("Invalid number");
                 }
                catch
                {
                     Console.ForegroundColor = ConsoleColor.DarkYellow;
                     Console.WriteLine("Please enter a valid value based on the number's list");
                     Console.ResetColor();
                     input = InputWithoutNull();
                }
             }
         }
    }
}
