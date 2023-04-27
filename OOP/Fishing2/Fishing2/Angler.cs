using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing2
{
    public class Angler
    {
        public readonly string name;
        private readonly List<Catch> catches;

        public Angler(string name)
        {
            this.name = name;
            catches = new List<Catch>();
        }

        public void Add(Catch c) { catches.Add(c); }

        public bool OK()
        {
            int i;
            int count = 0;
            for (i = 0; i < catches.Count && !(catches[i].species == "ponty" && catches[i].weight >= 1.0); i++) { }

            for (; i < catches.Count; i++)
            {
                if (catches[i].species == "harcsa" && catches[i].length >= 1.0)
                {
                    count++;
                }
            }
            return count >= 4;
        }
    }
}
