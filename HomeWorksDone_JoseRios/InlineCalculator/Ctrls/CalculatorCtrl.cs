using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace init.Ctrls
{
    public class CalculatorCtrl
    {
        public static List<object>? ExecuteAndSaveInlineAritmeticMaths(List<object> input, string? inputExpression, string? inputDescription)
        {
            if (input.Contains('*'))
            {
                var refIndex = input.IndexOf('*') - 1;
                var a = (decimal)input[refIndex];
                var b = (decimal)input[refIndex + 2];
                var result = a * b;
                input.RemoveAt(refIndex);
                input.RemoveAt(refIndex);
                input[refIndex] = result;
                return input;
            }
            else if (input.Contains('/'))
            {
                var refIndex = input.IndexOf('/') - 1;
                var a = (decimal)input[refIndex];
                var b = (decimal)input[refIndex + 2];
                var result = a / b;
                input.RemoveAt(refIndex);
                input.RemoveAt(refIndex);
                input[refIndex] = result;
                return input;
            }
            else if (input.Contains('-'))
            {
                var refIndex = input.IndexOf('-') - 1;
                var a = (decimal)input[refIndex];
                var b = (decimal)input[refIndex + 2];
                var result = a - b;
                input.RemoveAt(refIndex);
                input.RemoveAt(refIndex);
                input[refIndex] = result;
                return input;
            }
            else if (input.Contains('+'))
            {
                var refIndex = input.IndexOf('+') - 1;
                var a = (decimal)input[refIndex];
                var b = (decimal)input[refIndex + 2];
                var result = a + b;
                input.RemoveAt(refIndex);
                input.RemoveAt(refIndex);
                input[refIndex] = result;
                return input;
            }
            else
            {
                Console.WriteLine("Result: " + Math.Round((decimal)input[0], 2));
                HistoryCtrl.SaveCalculationHistoryItem(inputExpression, (decimal)input[0], inputDescription);
                return null;
            }
        }
    }
}
