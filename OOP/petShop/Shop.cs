using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShop
{
    public class Shop
    {
        public class ShopUnableToSellAnimalException : Exception { }
        public class ShopUnableToBuyAnimalException : Exception { }

        public string Name;
        private List<Invoice> invoices;
        private List<Partner> partners;
        private List<Animal> animals;

        public Shop(string name, List<Invoice> invoices, List<Partner> partners, List<Animal> animals)
        {
            Name = name;
            this.invoices = new List<Invoice>();
            this.invoices.AddRange(invoices);
            this.partners = new List<Partner>();
            this.partners.AddRange(partners);
            this.animals = new List<Animal>();
            this.animals.AddRange(animals);
        }

        public void Buy(string animalId, string partnerName)
        {
            bool T;
            Partner? partner = null;
            (T, partner) = searchPartner(partnerName);
            if (T)
            {
                Animal animal = partner.Sell(animalId);
                animals.Add(animal);
                Invoice invoice = new Invoice(DateTime.Now.ToString("yyyy.MM.dd"), animal.realValue(), "buy", partner, animal);
                invoices.Add(invoice);
            }
            else
            {
                throw new ShopUnableToBuyAnimalException();
            }
        }

        public void Sell(string animalId, string partnerName)
        {
            bool T1;
            Animal? animal = null;
            (T1, animal) = searchAnimal(animalId);
            bool T2;
            Partner? partner = null;
            (T2,  partner) = searchPartner(partnerName);
            if (T1 && T2)
            {
                animals.Remove(animal);
                partner.Buy(animal);
                Invoice invoice = new Invoice(DateTime.Now.ToString("yyyy.MM.dd"), animal.realValue(), "sell", partner, animal);
                invoices.Add(invoice);
            }
            else
            {
                throw new ShopUnableToSellAnimalException();
            }
        }

        public bool HasFinchWithColor(string color)
        {
            foreach (Animal animal in animals)
            {
                if(animal.speciesName == "finch")
                {
                    return true;
                }
            }
            return false;
        }

        public int HamsterCount() 
        {
            int sum = 0;
            foreach (Animal animal in animals)
            {
                if(animal.speciesName == "hamster")
                {
                    sum++;
                }
            }
            return sum;
        }

        public Animal? MostVluableTarantula() //originally it returned a Tarantull, but there's no reason to do that
        {
            int max = -1;
            Animal? maxT = null;
            foreach (Animal animal in animals)
            {
                if (animal.speciesName == "tarantula" && animal.realValue() > max)
                {
                    max = animal.realValue();
                    maxT = animal;
                }
            }

            return maxT;
        }

        public int InvoiceCountWithPartner(string partnerName)
        {
            int sum = 0;
            foreach(Invoice invoice in invoices)
            {
                if(invoice.getPartner().getName() == partnerName)
                {
                    sum++;
                }
            }

            return sum;
        }

        public int Profit()
        {
            int sum = 0;
            foreach(Invoice invoice in invoices)
            {
                if(invoice.getType() == "sell")
                {
                    sum += invoice.getPrice();
                }
                else if (invoice.getType() == "buy")
                {
                    sum -= invoice.getPrice();
                }
            }

            return sum;
        }

        private (bool, Animal?) searchAnimal(string animalId)
        {
            Animal? animal = null;
            animal = animals.FirstOrDefault(i => i.getId() == animalId);

            return (animal != null, animal);
        }

        private (bool, Partner?) searchPartner(string name)
        {
            Partner? partner = null;
            partner = partners.FirstOrDefault(i => i.getName() == name);

            return (partner != null, partner);
        }
    }
}
