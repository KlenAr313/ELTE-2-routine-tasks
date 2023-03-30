namespace mirrord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool solution;

            Stack<char> v = new Stack<char>();
            bool mirror = false;

            foreach (char x in s)
            {
                if (x == '#') 
                { 
                    if (v.Count() != 0)
                    {
                        mirror = true;
                    }
                }
                else
                {
                    if (!mirror)
                    {
                        v.Push(x);
                    }
                    else
                    {
                        if (v.Count() == 0)
                        {
                            mirror = false;
                        }
                        else if (v.Peek() != x)
                        {
                            solution = false;
                            Console.WriteLine(solution.ToString());
                        }
                        else
                        {
                            v.Pop();
                        }
                    }
                }
            }
            solution = v.Count() == 0;
            Console.WriteLine(solution.ToString());
        }
    }
}