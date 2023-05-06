using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4szorg
{
    internal class Client
    {
        public List<Card> Cards { get; set; }
        private List<string> Pins { get; set; }
        //public List<Invoice> Invoices { get; set; }
        private int need { get; set; }
        private int have { get; set; }

        public Client(Card card, string pin, int need)
        {
            Cards = new List<Card>();
            Pins = new List<string>();
            Cards.Add(card);
            Pins.Add(pin);
            this.need = need;
            have = 0;
        }

        public Client(List<Card> Cards, List<string> Pins, int need)
        {
            this.Cards = new List<Card>();
            this.Pins = new List<string>();
            Cards.ForEach(i => this.Cards.Add(i));
            Pins.ForEach(i => this.Pins.Add(i));
            this.need = need;
            have = 0;
        }

        public void useATM(ATM atm)
        {
            atm.Process(this);
        }

        public Card giveCard(int i)
        {
            return Cards[i];
        }

        public Card giveCard()
        {
            return Cards[0];
        }

        public string givePIN(int i)
        {
            return Pins[i];
        }

        public string givePIN()
        {
            return Pins[0];
        }

        public int askMoney()
        {
            return need;
        }

        public void setNeed(int need)
        {
            this.need = need;
        }

        public int getHave()
        {
            return have;
        }

        public void add(int amount)
        {
            have += amount;
        }
    }
}
