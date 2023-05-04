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

        public Card() { }

        public bool CheckPin(string PIN)
        {
            return PIN == this.PIN;
        }
    }
}
