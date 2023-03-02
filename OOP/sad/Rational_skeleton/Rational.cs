using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rational_skeleton
{
    internal class Rational
    {
        public class NullDenominator: Exception { }
        public class NullDivision : Exception { }
        private int n { get; set; }
        private int d { get; set; }

        public Rational(int n, int d)
        {
            if(d == 0)
                throw new NullDenominator();
            this.n = n;
            this.d = d;
        }

        public static Rational Add(Rational a, Rational b)
        {
            return new Rational(a.n * b.d + b.n*a.d, a.d * b.d);
        }

        public static Rational operator + (Rational a, Rational b)
        {
            return new Rational(a.n * b.d + b.n*a.d, a.d * b.d);
        }

        public Rational Add(Rational a)
        {
            return new Rational(a.n * this.d + this.n * a.d, a.d * this.d);
        }

        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational(a.n * b.d - b.n * a.d, a.d * b.d);
        }

        public static Rational operator * (Rational a, Rational b)
        {
            return new Rational(a.n * b.n, b.d * a.d);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            if (b.n == 0)
                throw new NullDivision();
            return new Rational(a.n * b.d, a.d * b.n);
        }

        public override string ToString()
        {
            return $"{n}/{d}";
        }

    }
}
