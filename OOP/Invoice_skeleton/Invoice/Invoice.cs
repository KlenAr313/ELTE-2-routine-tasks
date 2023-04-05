using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Invoice
    {
        private readonly string name;

        public int Sum { get; private set; }

        public Invoice(string name)
        {
            this.name = name;
            Sum = 0;
        }

        public void Add(Product p)
        {
            Sum += p.price;
        }
    }
}
