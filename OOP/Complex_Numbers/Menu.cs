using Complex_Numbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTM
{
    public class Menu
    {
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
                        Add();
                        break;
                    case 2:
                        Sub();
                        break;
                    case 3:
                        Mul();
                        break;
                    case 4:
                        Div();
                        break;
                }
            } while (n != 0);
        }

        private void MenuWrite()
        {
            Console.WriteLine("\n\n 0. - Quit");
            Console.WriteLine(" 1. - Add two Complex Number");
            Console.WriteLine(" 2. - Subtract two Complex Number");
            Console.WriteLine(" 3. - Multiply two Complex Number");
            Console.WriteLine(" 4. - Divide two Complex Number");
        }


        private void Add()
        {
            try
            {
                Console.WriteLine("\nGive the first complex number:");
                Complex a = ReadComplex();
                Console.WriteLine("Give the second complex number:");
                Complex b = ReadComplex();
                Console.WriteLine("\nSolution:");
                Console.Write(a + b);
            }
            catch (Exception)
            {
                Console.Write("Something went wrong! Please, try again!");
            }
        }

        private void Sub() 
        {
            try
            {
                Console.WriteLine("\nGive the first complex number:");
                Complex a = ReadComplex();
                Console.WriteLine("Give the second complex number:");
                Complex b = ReadComplex();
                Console.WriteLine("\nSolution:");
                Console.Write(a - b);
            }
            catch (Exception)
            {
                Console.Write("Something went wrong! Please, try again!");
            }
        }

        private void Mul()
        {
            try
            {
                Console.WriteLine("\nGive the first complex number:");
                Complex a = ReadComplex();
                Console.WriteLine("Give the second complex number:");
                Complex b = ReadComplex();
                Console.WriteLine("\nSolution:");
                Console.Write(a * b);
            }
            catch (Exception)
            {
                Console.Write("Something went wrong! Please, try again!");
            }
        }

        private void Div() 
        {
            try
            {
                Console.WriteLine("\nGive the first complex number:");
                Complex a = ReadComplex();
                Console.WriteLine("Give the second complex number:");
                Complex b = ReadComplex();
                Console.WriteLine("\nSolution:");
                Console.Write(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.Write("You cannot divide by zero! Please, try again!");
            }
            catch (Exception)
            {
                Console.Write("Something went wrong! Please, try again!");
            }
        }

        private Complex ReadComplex() 
        {
            bool good;
            do
            {
                good = false;
                try
                {
                    Console.WriteLine("Real prat:");
                    double x = Convert.ToDouble(Console.ReadLine().Replace(',','.'));

                    Console.WriteLine("Imeginary Part:");
                    double y = Convert.ToDouble(Console.ReadLine().Replace(',', '.'));

                    good = true;
                    return new Complex(x, y);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Wrong format! Please, try again!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong! Please, try again!");
                }    
            } while (!good);
            throw new Exception();
        }
    }
}
