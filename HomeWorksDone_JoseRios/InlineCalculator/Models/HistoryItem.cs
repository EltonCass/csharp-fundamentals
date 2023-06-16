using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace init.Models
{
    public class HistoryItem
    {
        public string? Expression { get; set; }
        public decimal Result { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDatetime { get; set; }

        public HistoryItem(string expr, decimal res, string? desc)
        {
            Expression = expr;
            Result = res;
            Description = desc;
            CreatedDatetime = DateTime.Now;
        }
        
        public HistoryItem() { }
    }
}
