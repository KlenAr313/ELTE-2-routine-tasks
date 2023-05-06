using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4szorg
{
    internal class ATM
    {
        private Center center { get; set;}
        public string place { get; set; }

        public ATM(string place, Center center)
        {
            this.center = center;
            this.place = place;
        }

        public void Process(Client client)
        {
            Card card = client.giveCard();
            if (card.CheckPin(client.givePIN()))
            {
                int amount = client.askMoney();
                int have = center.GetBalance(card.CardNumber);
                if (have > amount)
                {
                    center.ModifieBalace(card.CardNumber, (-1) * amount);
                    client.add(amount);
                }
                else { throw new Exception($"Not enough Money"); }
            }
            else { throw new Exception($"Wrong PIN Code"); }
        }
    }
}
