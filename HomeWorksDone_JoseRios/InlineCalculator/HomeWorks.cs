using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using init.Models;
using BetterConsoleTables;

namespace init
{
    public class HomeWorks
    {
        private static readonly string _fileName = "C:\\Users\\User\\Documents\\WORK\\CS-Course\\init\\history.json";
        public static int Fibonacci(int inputNum)
        {
            if (inputNum <= 0) return 0;
            if (inputNum <= 2) return 1;

            int result = 0;
            int prev = 0;
            int next = 1;

            for (int counter = 2; counter <= inputNum; counter++)
            {
                result = prev + next;
                prev = next;
                next = result;
            }
            return result;
        }

        public static List<object>? CalculateSingleOperationObjectListBase(List<object> input, string originalInput)
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
                //PrintList(input);
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
                //PrintList(input);
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
                //PrintList(input);
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
                //PrintList(input);
                return input;
            }
            else
            {
                Console.WriteLine("Result: " + Math.Round((decimal)input[0],2));
                SaveCalculationHistoryItem(originalInput, (decimal)input[0]);
                return null;
            }
        }

        public static void PrintList(List<object> arr)
        {
            var s = "";
            foreach(var o in arr)
                s += o.ToString();

            Console.WriteLine(s);
        }

        public static List<object> AritmeticObjectListFromInput(string input)
        {
            var arr = new List<object>();
            var str = "";
            var reg = new Regex(@"[+/\-*]");

            for (int i = 0; i < input.Length; i++)
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

        public static void SaveCalculationHistoryItem(string input, decimal result)
        {
            string jsonString = JsonSerializer.Serialize(
                new HistoryItem{ input=input, result=Math.Round(result,2), createdDatetime=DateTime.Now }
                );
            File.WriteAllText(_fileName, jsonString);
        }

        public static void PrintCalcuationHistoryTable()
        {
            string jsonStr = "";
            using (StreamReader myJsonFile = new StreamReader(_fileName))
            {
                jsonStr = myJsonFile.ReadToEnd();
            }
            var historyItem = JsonSerializer.Deserialize<HistoryItem>(jsonStr);
            Console.WriteLine("PREVIOUS OPERATION EXPRESSION:");
            var table = new Table("Input Expression", "Result", "Created Date");
            table.Config = TableConfiguration.MySql();
            table.AddRow(historyItem.input, historyItem.result, historyItem.createdDatetime);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(table);
        }
    }
}
