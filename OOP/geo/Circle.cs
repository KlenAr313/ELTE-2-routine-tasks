using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo
{
    internal class Circle
    {
        public class WrongRadiusException : Exception { }
        private Point o { get; set; }
        private double r { get; set; }

        public Circle(Point o, double r)
        {
            if (r < 0)
                throw new WrongRadiusException();

            this.o = o;
            this.r = r;
        }

        public bool include(Point p)
        {
            return p.Distane(o) <= this.r;
        }
    }
}
