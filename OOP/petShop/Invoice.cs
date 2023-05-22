using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShop
{
    public class Invoice
    {
        private string date;
        private int price;
        private string type;
        private Partner partner;
        private Animal animal;

        public Invoice(string date, int price, string type, Partner partner, Animal animal)
        {
            this.date = date;
            this.price = price;
            this.type = type;
            this.partner = partner;
            this.animal = animal;
        }

        public int getPrice()
        {
            return price;
        }

        public string getType()
        {
            return type;
        }

        public Partner getPartner()
        {
            return partner;
        }
    }
}
