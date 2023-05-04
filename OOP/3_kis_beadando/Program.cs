using System;
using System.Collections.Generic;
using TextFile;

namespace FileSystem
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write(Test("inp.txt"));
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
        }

        struct Item
        {
            public char sign;
            public Registration? reg;
            public Item(char c, Registration? r = null) { sign = c; reg = r; }
        };

        class WrongStructureException : Exception { };

        static int Test(string fname)
        {
            FileSystem root = new();

            TextFileReader reader = new(fname);
            Stack<Item> stack = new();

            while (ReadItem(ref reader, out char sign, out int size))
            {
                switch (sign)
                {
                    case 'F': stack.Push(new Item('F', new File(size))); break;
                    case 'K': stack.Push(new Item('K')); break;
                    case 'V':
                        Folder folder = new();
                        while ('K' != stack.Peek().sign)
                        {
                            folder.Add(stack.Peek().reg!);
                            stack.Pop();
                        }
                        Item item = stack.Peek();
                        stack.Pop();
                        item.sign = 'F';
                        item.reg = folder;
                        stack.Push(item);
                        break;
                }
            }

            while (stack.Count > 0)
            {
                if ('K' == stack.Peek().sign) throw new WrongStructureException();
                root.Add(stack.Peek().reg!);
                stack.Pop();
            }

            int res = root.GetSize();

            return res;
        }

        static bool ReadItem(ref TextFileReader reader, out char sign, out int size)
        {
            size = -1;
            bool res = reader.ReadChar(out sign);
            if (res)
            {
                if ('F' == sign) reader.ReadInt(out size);
            }
            return res;
        }
    }
}
