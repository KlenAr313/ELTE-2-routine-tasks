using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingContest
{
    public abstract class Fish
    {
        public abstract int Multi();

        public virtual bool IsCrap()
        {
            return false;
        }

        public virtual bool IsBream()
        {
            return false;
        }

        public virtual bool IsCatfish()
        {
            return false;
        }
    }

    public class Crap : Fish
    {
        private static Crap? instance;

        private Crap() { }

        public static Crap? Instance()
        {
            if (instance == null)
            {
                instance = new Crap();
            }
            return instance;
        }

        public override int Multi()
        {
            return 1;
        }

        public override bool IsCrap()
        {
            return true;
        }
    }

    public class Bream : Fish
    {
        private static Bream? instance;

        private Bream() { }

        public static Bream? Instance()
        {
            if (instance == null)
            {
                instance = new Bream();
            }
            return instance;
        }

        public override int Multi()
        {
            return 1;
        }

        public override bool IsBream()
        {
            return true;
        }
    }

    public class Catfish : Fish
    {
        private static Catfish? instance;

        private Catfish() { }

        public static Catfish? Instance()
        {
            if (instance == null)
            {
                instance = new Catfish();
            }
            return instance;
        }

        public override int Multi()
        {
            return 1;
        }

        public override bool IsCatfish()
        {
            return true;
        }
    }
}
