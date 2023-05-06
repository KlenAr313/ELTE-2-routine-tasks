using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4szorg
{
    internal class Center
    {
        private Dictionary<Bank, List<Card>> Banks { get; set; }

        public Center(List<Bank> banks, List<List<Card>> cards)
        {
            this.Banks = new Dictionary<Bank, List<Card>>();
            List<Card> list;
            for (int i = 0; i < banks.Count; i++)
            {
                list = new List<Card>();
                cards[i].ForEach(c => list.Add(c));
                this.Banks.Add(banks[i], list);
            }
        }

        public int GetBalance(string cardNumber)
        {
            (bool found, Bank bank) = SearchBank(cardNumber);
            if (found)
            {
                return bank.GetBalance(cardNumber);
            }
            else { throw new Exception($"Card with {cardNumber} number doesn't exists");}
        }

        public void ModifieBalace(string cardNumber, int amount)
        {
            (bool found, Bank bank) = SearchBank(cardNumber);
            if (found)
            {
                bank.ModifieBalance(cardNumber, amount);
            }
            else { throw new Exception($"Card with {cardNumber} number doesn't exists"); }
        }

        private (bool, Bank) SearchBank(string cardNumber)
        {
            foreach (var bank in Banks)
            {
                if(bank.Value.Where<Card>(i => i.CardNumber.Equals(cardNumber)).Count() != 0)
                {
                    return (true, bank.Key);
                }
            }
            return (false, Banks.FirstOrDefault().Key); 
        }
    }
}
