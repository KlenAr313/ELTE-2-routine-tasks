namespace StarWars
{
    public class Planet
    {
        public readonly string name;
        private readonly List<Starship> ships;

        public int NumberOfShips { get => ships.Count; }

        public Planet(string name)
        {
            this.name = name; this.ships = new List<Starship>();
        }

        public void ProtectedBy(Starship starship)
        {
            if (!ships.Contains(starship)) ships.Add(starship);
        }

        public void LeftBy(Starship starship)
        {
            if (ships.Contains(starship)) ships.Remove(starship);
        }

        public int TotalShield()
        {
            int sum = 0;
            foreach (var starship in ships) sum += starship.Shield;
            return sum;
        }

        public bool MaxFirePower(out double max, out Starship? bestShip)
        {
            bool l = false;
            max = 0.0;
            bestShip = null;

            foreach (var starship in ships)
            {
                double power = starship.FirePower();
                if (!l) { l = true; max = power; bestShip = starship; }
                else
                {
                    if (power > max) { max = power; bestShip = starship; }
                }
            }

            return l;
        }
    }
}
