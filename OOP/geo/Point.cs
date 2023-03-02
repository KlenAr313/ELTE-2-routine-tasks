using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo
{
    public class Point
    {
        private double x { get; set; }
        private double y { get; set; }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distane(Point p)
        {
            return  Math.Sqrt(Math.Pow( x - p.x, 2 ) + Math.Pow( y - p.y, 2 ));
        }
    }
}
