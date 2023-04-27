using System.Globalization;

namespace Fishing2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            try
            {
                InFile file = new InFile("input.txt");
                Console.WriteLine("Anglers satisfying condition:");
                while (file.Read(out Angler? angler))
                {
                    if (angler == null) continue;
                    else if (angler.OK()) Console.WriteLine(angler.name);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Input file does not exist!");
            }
        }
    }
}