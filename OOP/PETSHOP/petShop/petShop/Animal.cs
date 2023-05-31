using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShop
{
    public class Animal
    {
        private string id;
        private string colour;
        private int value;
        public string age;
        private Species species;
        public string speciesName;

        public Animal(string id, string colour, int value, string age, Species species)
        {
            this.id = id;
            this.colour = colour;
            this.value = value;
            this.age = age;
            this.species = species;
            this.speciesName = this.species.SpeciesName();
        }

        public string getId()
        {
            return id;
        }

        public string getColour()
        {
            return colour;
        }

        public int realValue()
        {
            return value * species.Multiplier(age);
        }
    }
}
