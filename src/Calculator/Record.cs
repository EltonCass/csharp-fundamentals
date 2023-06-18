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
        public string? Description { get; set; }

        public Record(double result, string expression, DateTime timestamp, string? description)
        {
            Result = result;
            Expression = expression;
            Timestamp = timestamp;
            Description = description;
        }
    }
}
