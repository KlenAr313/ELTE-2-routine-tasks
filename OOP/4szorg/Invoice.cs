using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4szorg
{
    internal class Invoice
    {
        public string InvoiceNumber { get; set; }
        private int Balance { get; set; }
        public List<Card> Cards { get; set; }

        public Invoice(string InvoiceNumber, int Balance, List<Card> cards)
        {
            this.InvoiceNumber = InvoiceNumber;
            this.Balance = Balance;
            this.Cards = new List<Card>();
            cards.ForEach(i=> this.Cards.Add(i));
        }
        
        public Invoice(string InvoiceNumber, int Balance, Card card)
        {
            this.InvoiceNumber = InvoiceNumber;
            this.Balance = Balance;
            this.Cards = new List<Card>();
            this.Cards.Add(card);
        }

        public int GetBalance()
        {
            return Balance;
        }

        public void ModifieBalance(int amount) 
        {
            this.Balance += amount;
        }

        public void Connect() { }
    }
}
