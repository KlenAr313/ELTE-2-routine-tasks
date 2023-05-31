using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShop
{
    public class Partner
    {
        public class PartnerUnableToSellAnimalException : Exception { }
        public class PartnerUnableToBuyAnimalException : Exception { }

        private string name;
        private List<Animal> animals;

        public Partner(string name, List<Animal> animals)
        {
            this.name = name;
            this.animals = new List<Animal>();
            this.animals.AddRange(animals);
        }

        public string getName()
        {
            return name;
        }

        public void Buy(Animal animal)
        {
            if (animals.FirstOrDefault(i => i == animal) == null)
            {
                this.animals.Add(animal);
            }
            else
            {
                throw new PartnerUnableToBuyAnimalException();
            }        
        }

        public Animal Sell(string animalId)
        {
            bool T;
            Animal? animal;
            (T, animal) = searchAnimal(animalId);
            if (T)
            {
                this.animals.Remove(animal);
                return animal;
            }
            else
            {
                throw new PartnerUnableToSellAnimalException();
            }
        }

        private (bool, Animal?) searchAnimal(string id)
        {
            Animal? animal = null;
            animal = animals.FirstOrDefault(i => i.getId() == id);

            return (animal != null, animal);
        }

        //for testing
        public int animalCount()
        {
            return animals.Count;
        }
    }
}
