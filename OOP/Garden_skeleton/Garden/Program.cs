namespace Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Garden garden = new(5);
                Gardener gardener = new(garden);

                gardener.Plant(1, Potato.Instance(), 3);
                gardener.Plant(2, Pea.Instance(), 3);
                gardener.Plant(4, Pea.Instance(), 3);
                gardener.Plant(3, Tulip.Instance(), 1);

                Console.Write("A betakarithato parcellak azonositoi: ");
                foreach (int i in gardener.garden.CanHarvest(8))
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            catch (Garden.WrongParcelNumberException)
            {
                Console.WriteLine("Nincs ilyen sorszamu parcella!");
            }
            catch (Parcel.NotEmptyParcelException)
            {
                Console.WriteLine("Nem ures parcellaba nem lehet ultetni!");
            }
        }
    }
}