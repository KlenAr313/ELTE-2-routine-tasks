using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTM
{
    public class LTM
    {
        // TODO: DifferentSizeException
        public class DifferentSizeException : Exception { };


        public class ReferenceToNullPartException : Exception { };

        private List<int> x = new List<int>();
        private int size;

        public LTM(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    x.Add(0);
                }
            }

            size = n;
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= size || j < 0 || j >= size) throw new IndexOutOfRangeException();
                if (i >= j) return x[Ind(i, j)];
                else return 0;
            }
            set
            {
                if (i < 0 || i >= size || j < 0 || j >= size) throw new IndexOutOfRangeException();
                if (i >= j) x[Ind(i, j)] = value;
                else throw new ReferenceToNullPartException();
            }
        }

        // TODO: operator +

        public static LTM operator +(LTM a, LTM b)
        {
            if (a.size != b.size) throw new DifferentSizeException();

            LTM c = new LTM(a.size);

            for (int i = 0; i < a.x.Count; i++)
            {
                c.x[i] = a.x[i] + b.x[i];
            }

            return c;
        }

        public static LTM operator *(LTM a, LTM b)
        {
            if (a.size != b.size) throw new DifferentSizeException();

            LTM c = new LTM(a.size);

            for (int i = 0; i < c.size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    c[i, j] = 0;
                    for (int k = j; k <= i; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    str += "\t" + this[i, j];
                }
                str += "\n";
            }
            return str;
        }

        private int Ind(int i, int j)
        {
            return i * (i + 1) / 2 + j;
        }
    }
}
