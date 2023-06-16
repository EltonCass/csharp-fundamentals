using BetterConsoleTables;
using init.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace init.Ctrls
{
    public class HistoryCtrl
    {
        private static readonly string _fileName = "C:\\Users\\User\\Documents\\WORK\\CS-Course\\csharp-fundamentals\\HomeWorksDone_JoseRios\\InlineCalculator\\history.json";

        public static void SaveCalculationHistoryItem(HistoryItem historyItem)
        {
            int limitOfHistoryItemsSaved = 2;
            List<HistoryItem> historyItems = GetHistoryItemsFromJson();
            if (historyItems.Count == limitOfHistoryItemsSaved) historyItems.RemoveAt(0);
            historyItems.Add(historyItem);
            string jsonString = JsonSerializer.Serialize(historyItems);
            File.WriteAllText(_fileName, jsonString);
        }

        public static void PrintCalcuationHistoryTable()
        {
            List<HistoryItem> historyItems = GetHistoryItemsFromJson();
            Console.WriteLine("PREVIOUS OPERATION EXPRESSION:");
            var table = new Table("Input Expression", "Result", "Description", "Created Date");
            table.Config = TableConfiguration.UnicodeAlt();
            historyItems.ForEach(item => table.AddRow(item.Expression, item.Result, item.Description, item.CreatedDatetime));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(table);
            Console.ResetColor();
        }

        private static List<HistoryItem> GetHistoryItemsFromJson()
        {
            string jsonStr = "";
            using (StreamReader myJsonFile = new StreamReader(_fileName))
            {
                jsonStr = myJsonFile.ReadToEnd();
            }
            List<HistoryItem> historyItems = JsonSerializer.Deserialize<List<HistoryItem>>(jsonStr) ?? new List<HistoryItem>();
            return historyItems;
        }
    }
}
