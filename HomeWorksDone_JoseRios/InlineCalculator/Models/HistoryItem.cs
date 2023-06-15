using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace init.Models
{
    public class HistoryItem
    {
        public string? input { get; set; }
        public decimal result { get; set; }
        public DateTime createdDatetime { get; set; }
    }
}
