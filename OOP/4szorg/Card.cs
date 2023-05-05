using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4szorg
{
    internal class Card
    {
        public string CardNumber { get; set; }
        private string PIN { get; set; }

        public Card(string CardNumber, string PIN) 
        {
            this.CardNumber = CardNumber;
            this.PIN = PIN;
        }

        public bool CheckPin(string PIN)
        {
            return PIN == this.PIN;
        }
    }
}
