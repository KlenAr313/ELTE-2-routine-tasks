using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bag
{
    internal class Bag
    {
        private List<Element> data { get; set; }
        public int? maxind { get; set; }

        public Bag()
        {
            data = new List<Element>();
            maxind = null;
        }

        public void SetEmpty()
        {
            data.Clear();
            maxind = null;
        }

        public bool Empty()
        {
            return data.Count == 0;
        }

        private int Search(int num)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].number == num)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int num)
        {
            int ind = Search(num);
            if (ind == -1)
            {
                data.Add(new Element(num));
            }
            else
            {
                data[ind].Add();
            }
        }

        public int Multipl(int num)
        {
            int ind = Search(num);
            if (ind != -1)
            {
                return data[ind].Get();
            }
            return 0;
        }

        public void Remove(int num)
        {
            int ind = Search(num);
            if(ind != -1)
            {
                data[ind].Sub();
                if (data[ind].Get() == 0)
                {
                    data.RemoveAt(ind);
                }
            }
        }

        public int Max()
        {
            if (data.Count != 0)
            {
                int maxI = 0;
                for (int i = 1; i < data.Count; i++)
                {
                    if (data[i].Get() > data[maxI].Get())
                    {
                        maxI = i;
                    }
                }
                this.maxind = maxI;
                return data[maxI].number;
            }
            throw new Exception("Bag is empty");
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; i++)
            {
                s += "(" + data[i].number + ", " + data[i].Get() + ")";
            }
            return s;
        }
    }
}
