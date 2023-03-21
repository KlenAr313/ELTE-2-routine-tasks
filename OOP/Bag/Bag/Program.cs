namespace Bag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bag");

            Bag bag = new Bag();

            int[] numbers = { 0, 6, 26, 42, 69 };
            foreach (int number in numbers) { bag.Insert(number); }

            Console.WriteLine(bag);

            int[] numbers2 = { 0, -1, 26, -7, 69 };
            foreach (int number in numbers2) { bag.Insert(number); }

            Console.WriteLine(bag.Multipl(69));
            Console.WriteLine(bag.Multipl(-1));

            Console.WriteLine(bag);

            bag.Remove(0);

            Console.WriteLine(bag);

            bag.Remove(0);

            Console.WriteLine(bag);

            bag.Remove(-7);

            Console.WriteLine(bag);

            bag.Remove(69);
            bag.Remove(69);

            Console.WriteLine(bag);

            Console.WriteLine(bag.Empty().ToString());

            Console.WriteLine(bag.Max());

            bag.Remove(26);

            Console.WriteLine(bag.Max());

            bag.SetEmpty();

            Console.WriteLine(bag.Empty().ToString());
        }
    }
}