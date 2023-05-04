using System.Text;
using TextFile;

namespace StarWars
{
    internal class Program
    {
        class NotExistingPlanetException : Exception { }

        static void Main(string[] args)
        {
            Galaxy galaxy = new("galaxy.txt");
            try
            {
                TextFileReader reader = new("input.txt");

                reader.ReadInt(out int n);
                for (int i = 0; i < n; ++i)
                {
                    reader.ReadString(out string planetName);
                    Planet? planet = galaxy.SearchPlanetByName(planetName);
                    if (planet == null) throw new NotExistingPlanetException();

                    reader.ReadInt(out int m);
                    for (int j = 0; j < m; ++j)
                    {
                        Starship? ship = null;
                        reader.ReadString(out string shipName);
                        reader.ReadString(out string type);
                        reader.ReadInt(out int shield);
                        reader.ReadInt(out int armor);
                        reader.ReadInt(out int crew);

                        if (type == "Breaker") ship = new Breaker(shipName, shield, armor, crew);
                        else if (type == "Lander") ship = new Lander(shipName, shield, armor, crew);
                        else if (type == "Laser") ship = new Laser(shipName, shield, armor, crew);

                        if (ship != null) ship.Protect(planet);
                    }
                }

                if (galaxy.MaxFirePower(out Starship? starship)) Console.WriteLine($"Starship with largest firepower: {starship!.name}\n");
                else Console.WriteLine("There isn't any planet protected by starships!\n");

                List<Planet> defenseless = galaxy.Defenseless();
                if (defenseless.Count > 0)
                {
                    Console.Write("Defenseless planets:");
                    StringBuilder shipNames = new StringBuilder();
                    foreach (Planet planet in defenseless)
                    {
                        shipNames.Append($"\n{planet.name}");
                    }
                    Console.WriteLine(shipNames.ToString());
                }
                else Console.WriteLine("All planets are protected!");

                int? shieldOfCoruscant = galaxy.TotalShieldOfPlanet("Coruscant");
                if (shieldOfCoruscant != null) Console.WriteLine($"\nShield of Coruscant: {shieldOfCoruscant}");
                else Console.WriteLine("No one is protecting Coruscant!");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Wrong file name somewhere!");
            }
            catch (Starship.StarShipInServiceException)
            {
                Console.WriteLine("Starhip is already protecting an other planet!");
            }
            catch (Starship.StarShipNotInServiceException)
            {
                Console.WriteLine("Starship isn't protecting any planet!");
            }
        }
    }
}