using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public abstract class Plant
    {
        protected readonly int ripeningTime;

        public int RipeningTime { get => ripeningTime; }

        protected Plant(int r) { ripeningTime = r; }

        public virtual bool IsVegetable() { return false; }

        public virtual bool IsFlower() => false;
    }

    public abstract class Vegetable : Plant
    {
        protected Vegetable(int r) : base(r) { }

        public override bool IsVegetable() { return true; }
    }

    public abstract class Flower : Plant
    {
        protected Flower(int r) : base(r) { }

        public override bool IsFlower() { return true; }
    }

    public class Potato : Vegetable
    {
        private static Potato? instance;

        private Potato() : base(5) { }

        public static Potato Instance()
        {
            if (instance == null) { instance = new Potato(); }
            return instance;
        }
    }

    public class Pea : Vegetable
    {
        private static Pea? instance;

        private Pea() : base(3) { }

        public static Pea Instance()
        {
            if (instance == null) { instance = new Pea(); }
            return instance;
        }
    }

    public class Onion : Vegetable
    {
        private static Onion? instance;

        private Onion() : base(4) { }

        public static Onion Instance()
        {
            if (instance == null) { instance = new Onion(); }
            return instance;
        }
    }

    public class Tulip : Flower
    {
        private static Tulip? instance;

        private Tulip() : base(7) { }

        public static Tulip Instance()
        {
            if (instance == null) { instance = new Tulip(); }
            return instance;
        }
    }

    public class Carnation : Flower
    {
        private static Carnation? instance;

        private Carnation() : base(10) { }

        public static Carnation Instance()
        {
            if (instance == null) { instance = new Carnation(); }
            return instance;
        }
    }

    public class Rose : Flower
    {
        private static Rose? instance;

        private Rose() : base(8) { }

        public static Rose Instance()
        {
            if (instance == null) { instance = new Rose(); }
            return instance;
        }
    }
}
