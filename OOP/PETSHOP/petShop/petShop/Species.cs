using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShop
{
    public abstract class Species
    {
        public abstract int Multiplier(string age);

        public virtual string SpeciesName()
        {
            return "non";
        }
    }

    public class Hamster : Species
    {
        private static Hamster? instance;

        private Hamster() { }

        public static Hamster? Instance()
        {
            if (instance == null)
            {
                instance = new Hamster();
            }
            return instance;
        }

        public override int Multiplier(string age)
        {
            if (age == "young")
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public override string SpeciesName()
        {
            return "hamster";
        }
    }

    public class Finch : Species
    {
        private static Finch? instance;

        private Finch() { }

        public static Finch? Instance()
        {
            if (instance == null)
            {
                instance = new Finch();
            }
            return instance;
        }

        public override int Multiplier(string age)
        {
            if (age == "young")
            {
                return 1;
            }
            else
            {
                return 3;
            }
        }

        public override string SpeciesName()
        {
            return "finch";
        }
    }

    public class Tarantula : Species
    {
        private static Tarantula? instance;

        private Tarantula() { }

        public static Tarantula? Instance()
        {
            if (instance == null)
            {
                instance = new Tarantula();
            }
            return instance;
        }

        public override int Multiplier(string age)
        {
            if(age == "young")
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }

        public override string SpeciesName()
        {
            return "tarantula";
        }
    }

}
