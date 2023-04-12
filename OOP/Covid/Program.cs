namespace Covid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InFile reader = new InFile("inp.txt");
                bool I = false;
                int max = 0;
                string maxDate = "";
                while (!reader.end())
                {
                    Day? day = reader.read();
                    if (day != null )
                    {
                        I = I || day.fresh > 5000;
                        if(max < day.sum)
                        {
                            max = day.sum;
                            maxDate = day.date;
                        }
                    }
                }
                reader.Dispose();
                Console.WriteLine((I ? "yes" : "no") + " " + maxDate);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Nem található ilyen file!");
            }
        }
    }
}