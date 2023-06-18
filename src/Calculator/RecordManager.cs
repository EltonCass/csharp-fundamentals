using Dumpify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class RecordManager
    {
        private Record[] records;

        public RecordManager(int recordsAmount)
        {
            records = new Record[recordsAmount];
        }

        public void AddRecord(Record record, int index)
        {
            records[index] = record;
        }

        public void PrintRecords()
        {
            // records.Dump();

            string line = '+' + new string('-', 96) + '+';
            string separators = "| {0, -10} | {1, -20} | {2, -25} | {3, -30} |";

            Console.WriteLine(line);
            Console.WriteLine(separators, "Result", "Expression", "Timestamp", "Description");
            Console.WriteLine(line);

            foreach (Record record in records)
            {
                if (string.IsNullOrEmpty(record.Description))
                {
                    PrintResultAndTimestamp(record, separators);
                }
                else
                {
                    PrintAll(record, separators);
                }
            }

            Console.WriteLine(line);
        }

        private void PrintAll(Record record, string separators)
        {
            Console.WriteLine(separators, record.Result, record.Expression, record.Timestamp, record.Description);
        }

        private void PrintResultAndTimestamp(Record record, string separators)
        {
            Console.WriteLine(separators, record.Result, null, record.Timestamp, null);
        }
    }
}
