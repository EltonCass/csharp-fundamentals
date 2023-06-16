using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace init.Ctrls
{
    public class CalculatorCtrl
    {
        public static decimal CalculateInlineAritmeticMath(List<object>? expressionAsObjectList)
        {
            decimal finalResult = 0;
            while (expressionAsObjectList != null)
            {
                if (expressionAsObjectList.Contains('*'))
                {
                    var refIndex = expressionAsObjectList.IndexOf('*') - 1;
                    var a = (decimal)expressionAsObjectList[refIndex];
                    var b = (decimal)expressionAsObjectList[refIndex + 2];
                    var result = a * b;
                    expressionAsObjectList.RemoveAt(refIndex);
                    expressionAsObjectList.RemoveAt(refIndex);
                    expressionAsObjectList[refIndex] = result;
                }
                else if (expressionAsObjectList.Contains('/'))
                {
                    var refIndex = expressionAsObjectList.IndexOf('/') - 1;
                    var a = (decimal)expressionAsObjectList[refIndex];
                    var b = (decimal)expressionAsObjectList[refIndex + 2];
                    var result = a / b;
                    expressionAsObjectList.RemoveAt(refIndex);
                    expressionAsObjectList.RemoveAt(refIndex);
                    expressionAsObjectList[refIndex] = result;
                }
                else if (expressionAsObjectList.Contains('-'))
                {
                    var refIndex = expressionAsObjectList.IndexOf('-') - 1;
                    var a = (decimal)expressionAsObjectList[refIndex];
                    var b = (decimal)expressionAsObjectList[refIndex + 2];
                    var result = a - b;
                    expressionAsObjectList.RemoveAt(refIndex);
                    expressionAsObjectList.RemoveAt(refIndex);
                    expressionAsObjectList[refIndex] = result;
                }
                else if (expressionAsObjectList.Contains('+'))
                {
                    var refIndex = expressionAsObjectList.IndexOf('+') - 1;
                    var a = (decimal)expressionAsObjectList[refIndex];
                    var b = (decimal)expressionAsObjectList[refIndex + 2];
                    var result = a + b;
                    expressionAsObjectList.RemoveAt(refIndex);
                    expressionAsObjectList.RemoveAt(refIndex);
                    expressionAsObjectList[refIndex] = result;
                }
                else
                {
                    finalResult = Math.Round((decimal)expressionAsObjectList[0], 2);
                    Console.WriteLine("Result: " + finalResult );
                    expressionAsObjectList = null;
                }
            }
            return finalResult;
        }
    }
}
