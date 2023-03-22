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
        public int maxind { get; set; }

        public Bag()
        {
            data = new List<Element>();
        }

        public void SetEmpty()
        {
            data.Clear();
        }

        public bool Empty()
        {
            return data.Count == 0;
        }

        private (bool,int) LogSearch(int num)
        {
            bool I = false;
            int ah = 0;
            int fh = data.Count - 1;
            int ind = -1;
            while (!I && ah <= fh)
            {
                ind = (ah + fh) / 2;
                if (data[ind].number > num)
                {
                    fh = ind - 1;
                }
                else if (data[ind].number == num)
                {
                    I = true;
                }
                else if (data[ind].number < num)
                {
                    ah = ind + 1;
                }
            }

            if (!I)
            {
                ind = ah;
            }

            return (I,ind);
        }

        public void Insert(int num)
        {
            int ind;
            bool I;
            (I, ind) = LogSearch(num);
            if (I)
            {
                data[ind].Add();
                if (data[maxind].Get() < data[ind].Get())
                {
                    maxind = ind;
                }
            }
            else
            {
                data.Insert(ind, new Element(num));
                if (data.Count == 1)
                {
                    maxind = 0;
                }
                else if (data.Count > 1 && maxind >= ind)
                {
                    maxind = ind;
                }
            }
        }

        public int Multipl(int num)
        {
            bool I;
            int ind;
            (I, ind)= LogSearch(num);
            if (I)
            {
                return data[ind].Get();
            }
            return 0;
        }

        public void Remove(int num)
        {
            bool I;
            int ind; 
            (I, ind) = LogSearch(num);
            if(I)
            {
                data[ind].Sub();
                if (data[ind].Get() == 0)
                {
                    data.RemoveAt(ind);
                }
            }

            if(data.Count > 0)
            {
                int maxI = 0;
                for (int i = 1; i < data.Count; i++)
                {
                    if (data[maxI].Get() < data[i].Get())
                    {
                        maxI = i;
                    }
                }
                maxind = maxI;
            }
        }

        public int Max()
        {
            if (data.Count > 0)
            {
                return data[maxind].number;
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
