namespace petShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop? shop = null;
            List<Animal> Sanimal = new List<Animal>();
            List<Partner> Spartners = new List<Partner>();
            List<Invoice> invoices = new List<Invoice>();
            try
            {
                StreamReader sr = new StreamReader("inp.txt");
                if (!sr.EndOfStream)
                {
                    try
                    {
                        string shopName = sr.ReadLine();
                        string line;
                        Animal one;
                        while (!sr.EndOfStream && (line = sr.ReadLine()) != "-")
                        {
                            one = createAnimal(line);
                            Sanimal.Add(one);
                        }

                        while (!sr.EndOfStream && (line = sr.ReadLine()) != "-")
                        {
                            string name = line;
                            List<Animal> Panimal = new List<Animal>();
                            while (!sr.EndOfStream && (line = sr.ReadLine()) != "*")
                            {
                                one = createAnimal(line);
                                Panimal.Add(one);
                            }
                            Partner partner = new Partner(name, Panimal);
                            Spartners.Add(partner);
                        }

                        shop = new Shop(shopName, invoices, Spartners, Sanimal);

                        while (!sr.EndOfStream && (line = sr.ReadLine()) != "-")
                        {
                            string[] s = line.Split(',');
                            if (s[0] == "sell")
                            {
                                shop.Sell(s[1], s[2]);
                            }
                            else if (s[0] == "buy")
                            {
                                shop.Buy(s[1], s[2]);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        Console.WriteLine(ex.Message);
                    }
                }
                sr.Close();

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }

            if (shop != null)
            {
                Console.WriteLine("a. Van-e egy kereskedésben adott színű pinty: yellow?\n" + shop.HasFinchWithColor("yellow"));
                Console.WriteLine("\nb. Hány hörcsöge van egy kereskedésnek?\n" + shop.HamsterCount());
                Animal? tar;
                if((tar = shop.MostVluableTarantula()) != null)
                {
                    Console.WriteLine("\nc. Melyik a legnagyobb eszmei értékű tarantullája egy kereskedésnek?\n" + tar.getId());
                }
                else 
                {
                    Console.WriteLine("\nc. Melyik a legnagyobb eszmei értékű tarantullája egy kereskedésnek?\nThere's no tarantulla");
                }
                Console.WriteLine("\nd. Hány szerződést kötött egy adott kereskedés egy adott partnerrel: AnyBreeder?\n" + shop.InvoiceCountWithPartner("AnyBreeder"));
                Console.WriteLine("\ne. Mekkora egy kereskedésnek a nyeresége\n" + shop.Profit());
                
            }
        }


        public static Animal createAnimal(string line)
        {
            Animal animal;
            Species species;

            string[] s = line.Split(',');
            if (s[4] == "H")
            {
                species = Hamster.Instance();
            }
            else if (s[4] == "T")
            {
                species = Tarantula.Instance();
            }
            else
            {
                species = Finch.Instance();
            }
            animal = new Animal(s[0], s[1], Convert.ToInt16(s[2]), s[3], species);
            return animal;
        }
    }
}