namespace Rational_skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Racionális számok");

            try
            {
                Rational a = new(3, -2);
                Rational b = new(-20, 3);

                a.Add(b);
                Rational.Add(a, b);

                Console.WriteLine("a + b = {0}", a + b);
                Console.WriteLine("a - b = {0}", a - b);
                Console.WriteLine("a * b = {0}", a * b);
                Console.WriteLine("a / b = {0}", a / b);
            }
            catch (Rational.NullDenominator)
            {
                Console.WriteLine("Érvénytelen szám");
            }
            catch (Rational.NullDivision)
            {
                Console.WriteLine("Nullával való osztás");
            }
        }
    }
}