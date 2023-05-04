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

        public ATM()
        {
            
        }

        public void Process(Client client)
        {
            Card card = client.giveCard();
            if (card.CheckPin(client.givePIN()))
            {
                int amount = client.askMoney();
                if (center.GetBalance(card.CardNumber) > amount)
                {
                    center.ModifieBalace(card.CardNumber, (-1) * amount);
                }
                else { throw new Exception($"Not enough Money"); }
            }
            else { throw new Exception($"Wrong PIN Code"); }
        }
    }
}
