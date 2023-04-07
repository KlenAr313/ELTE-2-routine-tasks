using System.Globalization;
using System.Linq.Expressions;
using TextFile;

namespace Cactus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1("inp.txt");
            Task2("inp.txt");
        }

        public static void Task1(string filename)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            try
            {
                InFile file = new(filename);
                Cactus? plant;

                while ((plant = file.Read()) != null)
                {
                    if (plant.colour == "piros")
                    {
                        Console.WriteLine("Van-e piros: True");
                        file.Dispose();
                        return;
                    }
                }
                Console.WriteLine("Van-e piros: False");
                file.Dispose();
                return;
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Nem létezik a megadott input fájl!");
            }

            
        }

        public static void Task2(string filename)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            try
            {
                InFile file = new(filename);
                Cactus? plant;

                bool ex = false;
                int max = -1;
                string name = "";

                while ((plant = file.Read()) != null)
                {
                    if (plant.colour == "piros" && ex)
                    {
                        if (plant.size > max)
                        {
                            max = plant.size;
                            name = plant.name;
                        }
                    }
                    else if (plant.colour == "piros" && !ex)
                    {
                        max = plant.size;
                        name = plant.name;
                        ex = true;
                    }
                }

                file.Dispose();

                if (ex) Console.WriteLine($"Legnagyobb piros kaktusz: {name}, meret: {max}");
                else Console.WriteLine("Nem volt piros kaktusz!");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Nem létezik a megadott input fájl!");
            }
        }
    }
}