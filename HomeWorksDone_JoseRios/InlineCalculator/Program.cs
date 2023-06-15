using init.Models;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace init
{
    class App
    {
        public static void Main(string[] args)
        {
            HomeWorks.PrintCalcuationHistoryTable();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Type your aritmetic operation please:");
            Console.ResetColor();
        
            var input = Console.ReadLine();
            List<object>? objs = HomeWorks.AritmeticObjectListFromInput(input);

            while (objs != null)
                objs = HomeWorks.CalculateSingleOperationObjectListBase(objs, input);
        }
    }
}
