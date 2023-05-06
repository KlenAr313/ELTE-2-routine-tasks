using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _4szorg
{
    internal class Bank
    {
        private List<Invoice> Invoices { get; set; }

        public Bank(List<Invoice> invoices) 
        {
            this.Invoices = new List<Invoice>();
            invoices.ForEach(i=> this.Invoices.Add(i));
        }

        public void OpenInvoice() { 
        }

        public void AddCard() { }

        public int GetBalance(string cardNumber)
        {
            (bool found, Invoice invoice) = SearchInvoice(cardNumber);
            if (found)
            {
                return invoice.GetBalance();
            }
            else
            {
                throw new Exception($"Card with {cardNumber} number doesn't exists");
            }
        }
        
        public void ModifieBalance(string cardNumber, int amount)
        {
            (bool found, Invoice invoice) = SearchInvoice(cardNumber);
            if (found)
            {
                invoice.ModifieBalance(amount);
            }
            else { throw new Exception($"Card with {cardNumber} number doesn't exists"); }
        }

        private (bool, Invoice) SearchInvoice(string cardNumber)
        {
            foreach (Invoice invoice in Invoices)
            {
                if (invoice.Cards.Where(i => i.CardNumber == cardNumber).Count() != 0)
                {
                    return (true, invoice);
                }
            }
            return (false, Invoices[0]);
        }
    }
}
