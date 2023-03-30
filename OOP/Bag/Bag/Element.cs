using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag
{
    internal class Element
    {
        public int number { get; set; }
        private int value { get; set; }

        public Element(int number)
        {
            this.number = number;
            value = 1;
        }

        public void Add()
        {
            this.value++;
        }

        public void Add(int value)
        {
            this.value += value;
        }

        public void Sub()
        {
            this.value--;
        }

        public void Sub(int value)
        {
            this.value -= value;
        }

        public int Get()
        {
            return this.value;
        }
    }
}
