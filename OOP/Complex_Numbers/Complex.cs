using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Numbers
{
    internal class Complex
    {
        private double x { get; set; }
        private double y { get; set; }

        public Complex(double a, double b)
        {
            this.x = a;
            this.y = b;
        }

        public static Complex Add(Complex a, Complex b)
        {
            return new Complex( a.x + b.x, a.y + b.y);
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return Add(a,b);
        }

        public static Complex Sub(Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }
        
        public static Complex operator -(Complex a, Complex b)
        {
            return Sub(a,b);
        }

        public static Complex Mul(Complex a, Complex b)
        {
            return new Complex(a.x * b.x - a.y * b.y, a.x * b.y + a.y * b.x);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return Mul(a,b);
        }

        public static Complex Div(Complex a, Complex b)
        {
            if (b.x == 0 &&  b.y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return new Complex((a.x * b.x + a.y * b.y) / (Math.Pow(b.x, 2) + Math.Pow(b.y, 2)), (a.y * b.x - a.x * b.y) / (Math.Pow(b.x, 2) + Math.Pow(b.y, 2)));
            }
        }

        public static Complex operator / (Complex a, Complex b)
        {
            return Div(a,b);
        }

        public override string ToString()
        {
            string s = "";
            if (x != 0)
            {
                s += x.ToString();
            }
            if(y < 0)
            {
                s += y.ToString() + "i";
            }
            else if  (y > 0)
            {
                if(x == 0)
                {
                    s += y.ToString() + "i";
                }
                else
                {
                    s += "+" + y.ToString() + "i";
                }
            }
            return s;
        }
    }
}
