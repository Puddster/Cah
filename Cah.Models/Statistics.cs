using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cah.Models
{
    public class Statistics
    {
        public int StatisticId { get; set; }
        public int? DealCount { get; set; }
        public int? PlayCount { get; set; }
        public int? WinCount { get; set; } 
    }
}
