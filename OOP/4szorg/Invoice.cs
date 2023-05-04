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

        public Invoice()
        {
            
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
