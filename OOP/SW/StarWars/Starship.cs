namespace StarWars
{
    public abstract class Starship
    {
        public class StarShipInServiceException : Exception { }
        public class StarShipNotInServiceException : Exception { }

        public readonly string name;
        protected readonly int shield;
        protected readonly int armor;
        protected readonly int crew;

        public int Shield { get => shield; }
        public Planet? Planet { get; private set; }

        protected Starship(string name, int shield, int armor, int crew)
        {
            this.name = name; this.shield = shield; this.armor = armor; this.crew = crew;
        }

        public void Protect(Planet planet)
        {
            if (Planet != null) throw new StarShipInServiceException();
            Planet = planet;
            planet.ProtectedBy(this);
        }

        public void Leave()
        {
            if (Planet == null) throw new StarShipNotInServiceException();
            Planet.LeftBy(this);
            Planet = null;
        }

        public abstract double FirePower();
    }

    // TODO: class Breaker

    // TODO: class Lander

    // TODO: class Laser
}
