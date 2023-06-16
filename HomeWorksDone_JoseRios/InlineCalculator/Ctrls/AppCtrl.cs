using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using init.Models;
using init.Utils;

namespace init.Ctrls
{
    public class AppCtrl
    {

        public static void Run()
        {
            HistoryCtrl.PrintCalcuationHistoryTable();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Type your aritmetic operation please:");
            Console.ResetColor();

            string inputExpression = InputValidator.InputWithoutNull();
            inputExpression = InputValidator.RemoveLetterFromAritmeticExpression(inputExpression);
            Console.WriteLine($"Please add a description for the expression '{inputExpression}'");
            string? inputDescription = Console.ReadLine();
            List<object>? expressionAsObjectList = TurnIntoAritmeticObjectList(inputExpression);
            decimal result = CalculatorCtrl.CalculateInlineAritmeticMath(expressionAsObjectList);
            HistoryCtrl.SaveCalculationHistoryItem(new HistoryItem(inputExpression, result, inputDescription));
        }

        public static List<object> TurnIntoAritmeticObjectList(string? input)
        {
            var arr = new List<object>();
            var str = "";
            var reg = new Regex(@"[+/\-*]");

            for (int i = 0; i < input?.Length; i++)
            {
                if (reg.IsMatch(input[i].ToString()) && i != 0)
                {
                    arr.Add(decimal.Parse(str));
                    arr.Add(input[i]);
                    str = "";
                }
                else
                {
                    str += input[i].ToString();
                }

                if (i == input.Length - 1) arr.Add(decimal.Parse(str));
            }
            return arr;
        }
    }
}
