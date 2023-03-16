using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrQueue
{
    public class PrQueue
    {
        public class PrQueueEmpty : Exception { }

        private readonly List<Element> seq = new List<Element>();

        public IList<Element> Seq { get => seq; }

        public void SetEmpty() { seq.Clear(); }

        public bool IsEmpty() { return seq.Count == 0; }

        public void Add(Element e) { seq.Add(e); }

        public Element GetMax()
        {
            if (IsEmpty()) throw new PrQueueEmpty();
            
            int maxind = MaxIndex();
            return seq[maxind];
        }

        public Element RemMax()
        {
            if(IsEmpty()) throw new PrQueueEmpty();

            int maxind = MaxIndex();
            Element e = seq[maxind];
            seq[maxind] = seq[^1];
            seq.RemoveAt(maxind);

            return e;
        }

        public void Write()
        {
            if (IsEmpty()) { Console.WriteLine("PrQueue is empty!"); return; }

            foreach (Element e in seq)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private int MaxIndex()
        {
            int ind = 0;
            for (int i = 1; i < seq.Count; i++)
            {
                if (seq[i].Pr > seq[ind].Pr)
                {
                    ind = i;
                }
            }

            return ind;
        }
    }
}
