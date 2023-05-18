using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingContest
{
    public class Fisher
    {
        public class ExistingCatchException : Exception { }

        public readonly string name;
        private readonly List<Catch> catches;

        public Fisher(string name) { this.name = name; catches = new List<Catch>(); }

        public void Catch(DateTime time, Fish fish, double weight, Contest contest)
        {
            bool l = false;
            foreach (Catch c in catches)
            {
                if (c.Time.Equals(time) && c.Contest.Equals(contest))
                {
                    l = true;
                    break;
                }
            }
            if (l) throw new ExistingCatchException();
            catches.Add(new Catch(time, fish, weight, this, contest));
        }

        public double TotalValue(Contest contest)
        {
            double s = 0;
            foreach (Catch c in catches)
            {
                if (c.Contest == contest) s += c.Value();
            }
            return s;
        }

        public bool CaugthCatfish(Contest contest)
        {
            foreach (Catch c in catches)
            {
                if (c.Fish.IsCatfish() && c.Contest == contest) return true;
            }
            return false;
        }
    }
}
