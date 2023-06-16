using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Record
    {
        public double Result { get; set; }
        public string Expression { get; set; }
        public DateTime Timestamp { get; set; }

        public Record(double result, string expression, DateTime timestamp)
        {
            Result = result;
            Expression = expression;
            Timestamp = timestamp;
        }
    }
}
