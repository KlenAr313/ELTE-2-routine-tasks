using TextFile;

namespace StarWars
{
    public class Galaxy
    {
        public List<Planet> Planets { get; private set; }

        public Galaxy(string filePath)
        {
            Planets = new List<Planet>();
            TextFileReader reader = new TextFileReader(filePath);
            while (reader.ReadString(out string name)) Planets.Add(new Planet(name));
        }

        public Planet? SearchPlanetByName(string name)
        {
            foreach (Planet planet in Planets)
            {
                if (string.Equals(planet.name, name)) return planet;
            }
            return null;
        }

        public bool MaxFirePower(out Starship? bestShip)
        {
            bool l = false;
            double max = 0.0;
            bestShip = null;

            foreach (Planet planet in Planets)
            {
                bool ll = planet.MaxFirePower(out double power, out Starship? ship);
                if (!ll) continue;
                if (!l) { l = true; max = power; bestShip = ship; }
                else
                {
                    if (power > max) { max = power; bestShip = ship; }
                }
            }

            return l;
        }

        public List<Planet> Defenseless()
        {
            List<Planet> results = new List<Planet>();
            foreach (Planet planet in Planets)
            {
                if (planet.NumberOfShips == 0) results.Add(planet);
            }
            return results;
        }

        public int? TotalShieldOfPlanet(string name)
        {
            Planet? planet = SearchPlanetByName(name);
            int? result = planet != null ? planet.TotalShield() : null;
            return result;
        }
    }
}
