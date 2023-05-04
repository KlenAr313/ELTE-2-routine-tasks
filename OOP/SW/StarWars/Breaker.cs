using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class Breaker : Starship
    {
        public Breaker(string name, int shield, int armor, int crew) : base(name, shield, armor, crew)
        {
        }

        public override double FirePower()
        {
            return armor/2;
        }
    }
}
