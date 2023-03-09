using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTM
{
    public class Menu
    {
        private readonly LTM[] matrices = new LTM[2];
        private const int size = 3;

        public Menu()
        {
            matrices[0] = new LTM(size);
            matrices[1] = new LTM(size);
        }

        public void Run()
        {
            int n;
            do
            {
                MenuWrite();
                try
                {
                    n = int.Parse(Console.ReadLine()!);
                }
                catch (System.FormatException) { n = -1; }

                switch (n)
                {
                    case 1:
                        GetElement(0);
                        break;
                    case 2:
                        GetElement(1);
                        break;
                    case 3:
                        SetElement(0);
                        break;
                    case 4:
                        SetElement(1);
                        break;
                    case 5:
                        WriteMatrix(0);
                        break;
                    case 6:
                        WriteMatrix(1);
                        break;
                    case 7:
                        Sum();
                        break;
                    case 8:
                        Mul();
                        break;
                }
            } while (n != 0);
        }

        private void MenuWrite()
        {
            Console.WriteLine("\n\n 0. - Quit");
            Console.WriteLine(" 1. - Get an element of the matrix A");
            Console.WriteLine(" 2. - Get an element of the matrix B");
            Console.WriteLine(" 3. - Overwrite an element of the matrix A");
            Console.WriteLine(" 4. - Overwrite an element of the matrix B");
            Console.WriteLine(" 5. - Write matrix A");
            Console.WriteLine(" 6. - Write matrix B");
            Console.WriteLine(" 7. - Add matrices");
            Console.WriteLine(" 8. - Multiply matrices");
        }

        private void GetElement(int x)
        {
            bool ok;
            do
            {
                ok = false;
                try
                {
                    Console.WriteLine("Give the index of the row: ");
                    int i = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Give the index of the column: ");
                    int j = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"a[{i},{j}]={matrices[x][i - 1, j - 1]}");
                    ok = true;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine($"Index must be between 1 and {size}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"Index must be between 1 and {size}");
                }
            } while (!ok);
        }

        private void SetElement(int x)
        {
            bool ok;
            do
            {
                ok = false;
                try
                {
                    Console.WriteLine("Give the index of the row: ");
                    int i = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Give the index of the column: ");
                    int j = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Give the value: ");
                    int e = int.Parse(Console.ReadLine()!);
                    matrices[x][i - 1, j - 1] = e;
                    ok = true;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine($"Index must be between 1 and {size}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"Index must be between 1 and {size}");
                }
                catch (LTM.ReferenceToNullPartException)
                {
                    Console.WriteLine("Only the elements in the diagonal or below it may be rewritten");
                }
            } while (!ok);
        }

        private void WriteMatrix(int x)
        {
            Console.Write(matrices[x].ToString());
        }

        private void Sum()
        {
            try
            {
                Console.Write((matrices[0] + matrices[1]).ToString());
            }
            catch (LTM.DifferentSizeException)
            {
                Console.Write("You can not sum different sized matrices!");
            }
        }

        private void Mul()
        {
            try
            {
                Console.Write((matrices[0] * matrices[1]).ToString());
            }
            catch (LTM.DifferentSizeException)
            {
                Console.Write("You can not multiply different sized matrices!");
            }
        }
    }
}
