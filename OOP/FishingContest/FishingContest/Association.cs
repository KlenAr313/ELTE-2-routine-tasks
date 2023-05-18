using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingContest
{
    public class Association
    {
        public class MemberAlreadyJoinedException : Exception { }
        public class ExistingContestException : Exception { }

        private readonly List<Contest> contests;

        public List<Fisher> Members { get; }

        public Association() { contests = new List<Contest>(); Members = new List<Fisher>(); }

        public void Join(string name)
        {
            if (Search(name) != null) throw new MemberAlreadyJoinedException();
            Members.Add(new Fisher(name));
        }

        public Fisher? Search(string name)
        {
            foreach (Fisher fisher in Members)
            {
                if (fisher.name == name) return fisher;
            }
            return null;
        }

        public Contest Organize(string place, DateTime start)
        {
            bool l = false;
            foreach (Contest c in contests)
            {
                if (c.place == place && c.Start == start)
                {
                    l = true;
                    break;
                }
            }
            if (l) throw new ExistingContestException();

            Contest contest = new(this, place, start);
            contests.Add(contest);
            return contest;
        }

        public bool bestContest(out Contest? contest)
        {
            contest = contests.Where(i => i.AllCatfish()).Aggregate((i1, i2) => i1.TotalAmount() > i2.TotalAmount() ? i1 : i2);
            return contest != null;
        }
    }
}
