using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid
{
    internal class Day
    {
        public string date { get; set; }
        public int fresh { get; set; }
        public int sum { get; set; }

        public Day(string date, int full, int sum)
        {
            this.date = date; 
            this.fresh = full;
            this.sum = sum;
        }
    }
}
