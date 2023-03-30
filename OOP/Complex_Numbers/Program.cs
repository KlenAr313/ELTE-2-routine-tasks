using LTM;

namespace Complex_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complex Numbers");

            Menu menu = new();
            menu.Run();

            Console.WriteLine("Köszönjük, hogy cégünket választotta!");
        }
    }
}