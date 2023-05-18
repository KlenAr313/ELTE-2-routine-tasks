using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingContest
{
    public class Contest
    {
        public class FisherNotRegistratedException : Exception { }
        public class AlreadySignedUpException : Exception { }

        public readonly string place;
        private readonly Association association;
        private readonly List<Fisher> fishers;

        public DateTime Start { get; }

        public Contest(Association association, string place, DateTime start)
        {
            this.association = association; this.place = place; Start = start; fishers = new List<Fisher>();
        }

        public void SignUp(Fisher fisher)
        {
            if (!association.Members.Contains(fisher)) throw new FisherNotRegistratedException();
            if (fishers.Contains(fisher)) throw new AlreadySignedUpException();
            fishers.Add(fisher);
        }

        public double TotalAmount()
        {
            double s = 0.0;
            foreach (Fisher f in fishers)
            {
                s += f.TotalValue(this);
            }
            return s;
        }

        public bool AllCatfish()
        {
            foreach (Fisher f in fishers)
            {
                if (!f.CaugthCatfish(this)) return false;
            }
            return true;
        }
    }
}
