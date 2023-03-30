namespace Invoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InFile file = new("input.txt");
                Invoice? invoice;
                int income = 0;

                while ((invoice = file.Read()) != null)
                {
                    income += invoice.Sum;
                }

                Console.WriteLine($"Teljes bevetel: {income}");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("A megadott fajl nem letezik!");
            }
        }
    }
}