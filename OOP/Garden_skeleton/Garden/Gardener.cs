using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Gardener
    {
        public Garden garden;

        public Gardener(Garden g) { garden = g; }

        public void Plant(int i, Plant plant, int date)
        {
            garden.Plant(i, plant, date);
        }

        public void Harvest(int i) { garden.Harvest(i); }
    }
}
