using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrQueue
{
    public class Menu
    {
        private readonly PrQueue pq = new();

        public void Run()
        {
            int v;
            do
            {
                v = GetMenuPoint();
                switch (v)
                {
                    case 1:
                        PutIn();
                        Write();
                        break;
                    case 2:
                        RemoveMax();
                        Write();
                        break;
                    case 3:
                        GetMax();
                        Write();
                        break;
                    case 4:
                        CheckEmpty();
                        break;
                    case 5:
                        Write();
                        break;
                    default:
                        Console.WriteLine("\nGoodbye!");
                        break;
                }
            } while (v != 0);
        }

        private int GetMenuPoint()
        {
            int v;
            do
            {
                Console.WriteLine("\n********************************");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("1. Insert into PrQueue.");
                Console.WriteLine("2. Remove highest priority element.");
                Console.WriteLine("3. Get highest priority element.");
                Console.WriteLine("4. Is PrQueue empty?");
                Console.WriteLine("5. Write content of PrQueue.");
                Console.WriteLine("****************************************");

                try
                {
                    v = int.Parse(Console.ReadLine()!);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Wrong option!");
                    v = -1;
                }
            } while (v < 0 || v > 5);
            return v;
        }

        private void PutIn()
        {
            Element e = new();
            Console.WriteLine("What should we put in?");
            e.Read();
            pq.Add(e);
        }

        private void RemoveMax()
        {
            Element e;
            try
            {
                e = pq.RemMax();
                Console.WriteLine("Removed element: ({0}, {1})", e.Pr, e.Data);
            }
            catch (PrQueue.PrQueueEmpty)
            {
                Console.WriteLine("Removal failed! PrQueue is empty!\n");
            }
        }

        private void GetMax()
        {
            Element e;
            try
            {
                e = pq.GetMax();
                Console.WriteLine("Highest priority element: ({0}, {1})", e.Pr, e.Data);
            }
            catch (PrQueue.PrQueueEmpty)
            {
                Console.WriteLine("There is no highest priority element! PrQueue is empty!\n");
            }
        }

        private void CheckEmpty()
        {
            if (pq.IsEmpty())
                Console.WriteLine("PrQueue is empty!");
            else
                Console.WriteLine("PrQueue is not empty!");
        }

        private void Write()
        {
            pq.Write();
        }
    }
}
