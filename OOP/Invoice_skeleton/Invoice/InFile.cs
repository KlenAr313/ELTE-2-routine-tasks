using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace Invoice
{
    public class InFile
    {
        private readonly TextFileReader reader;

        public InFile(string inputPath)
        {
            reader = new TextFileReader(inputPath);
        }

        public Invoice? Read()
        {
            Invoice? invoice = null;

            if (reader.ReadLine(out string line))
            {
                char[] separators = { ' ', '\t' };
                string[] items = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                invoice = new Invoice(items[0]);
                for (int i = 1; i < items.Length; i += 4)
                {
                    Product c = new Product
                    {
                        name = items[i],
                        price = int.Parse(items[i + 1])
                    };

                    invoice.Add(c);
                }
            }

            return invoice;
        }
    }
}
