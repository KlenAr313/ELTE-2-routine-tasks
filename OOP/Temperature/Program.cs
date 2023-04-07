using System.ComponentModel;
using System.Globalization;

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double average = 0;
            bool l = false;
            double min = 0;
            double e = 0;
            double s = 0;
            int db = 0;
            try
            {
                StreamReader x = new StreamReader("inp.txt");
                List<double> list = new List<double>();
                while (!x.EndOfStream)
                {
                    string? line = x.ReadLine();
                    if (line != null)
                    {
                        string[] data = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < data.Length; j++)
                        {
                            if (double.TryParse(data[j], out e))
                            {
                                list.Add(e);
                            }
                        }

                    }
                }
                int i = 0;
                for (; i < list.Count && list[i] >= 0; i++)
                {
                    s += list[i];
                    db++;
                }

                average = s / db;
                l = true;
                min = list[i];

                for (; i < list.Count; i++)
                {
                    l = l && list[i] < 0;
                    min = Math.Min(min, list[i]);
                }

                x.Close();
                x.Dispose();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Nem létezik a megadott input fájl!");
            }

            Console.WriteLine($"Atlag: {Math.Round(average, 2)}\nMindig fagyott: {l}\nLegalacsonyabb: {min}");
        }
    }
}