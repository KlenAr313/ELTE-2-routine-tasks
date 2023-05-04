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
        public List<Invoice> Invoices { get; set; }
        private int need { get; set; }

        public Client()
        {
            
        }

        public void getMoney(ATM atm)
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
    }
}
