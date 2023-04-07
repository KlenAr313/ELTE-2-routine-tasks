using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public struct Product
    {
        public int price { get; set; }
        public string name { get; set; }

        public Product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }
        // TODO: members and constructor
    }
}
