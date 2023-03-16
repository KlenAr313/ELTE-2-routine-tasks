using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrQueue
{
    public class Element
    {
        private int pr;
        private string data;

        public int Pr { get => pr; }
        public string Data { get => data; }

        public Element() { data = string.Empty; }
        
        public Element(int pr, string data)
        {
            this.pr = pr;
            this.data = data;
        }

        public void Read()
        {
            Console.Write("Data: ");
            data = Console.ReadLine()!;

            bool ok;
            do
            {
                Console.WriteLine("Priority of element (integer): ");
                try
                {
                    pr = int.Parse(Console.ReadLine()!);
                    ok = true;
                }
                catch (System.FormatException)
                {
                    ok = false;
                }
            } while (!ok);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            Element? that = obj as Element;
            if (this.Pr == that!.Pr && this.Data == that.Data) return true;
            else return false;
        }

        public override string ToString()
        {
            return $"({pr.ToString()}, {data})";
        }
    }
}
