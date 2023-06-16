using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace init.Models
{
    public class HistoryItem
    {
        public string? expression { get; set; }
        public decimal result { get; set; }
        public string? description { get; set; }
        public DateTime createdDatetime { get; set; }
    }
}
