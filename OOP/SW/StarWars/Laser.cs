using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class Laser : Starship
    {
        public Laser(string name, int shield, int armor, int crew) : base(name, shield, armor, crew)
        {
        }

        public override double FirePower()
        {
            return shield;
        }
    }
}
