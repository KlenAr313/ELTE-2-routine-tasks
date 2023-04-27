using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing2
{
    public class Catch
    {
        public readonly string time;
        public readonly string species;
        public readonly double weight;
        public readonly double length;

        public Catch(string time, string species, double weight, double length)
        {
            this.time = time; this.species = species; this.weight = weight; this.length = length;
        }
    }
}
