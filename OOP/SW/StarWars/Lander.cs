using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    internal class Lander : Starship
    {
        public Lander(string name, int shield, int armor, int crew) : base(name, shield, armor, crew)
        {
        }

        public override double FirePower()
        {
            return crew;
        }
    }
}
