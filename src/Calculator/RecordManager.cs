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
            records.Dump();
        }
    }
}
