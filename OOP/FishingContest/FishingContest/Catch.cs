using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingContest
{
    public class Catch
    {
        private readonly double weight;
        private readonly Fisher fisher;

        public DateTime Time { get; }
        public Fish Fish { get; }
        public Contest Contest { get; }

        public Catch(DateTime time, Fish fish, double weight, Fisher fisher, Contest contest)
        {
            this.Time = time; Fish = fish; this.weight = weight; this.fisher = fisher; this.Contest = contest;
        }

        public double Value() { return weight * Fish.Multiplier(); }
    }
}
