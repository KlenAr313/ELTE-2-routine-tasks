using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace Cactus
{
    internal class InFile
    {
        private readonly StreamReader reader;

        public InFile(string inputPath)
        {
            reader = new StreamReader(inputPath);
        }

        public Cactus? Read()
        {
            Cactus? cactus = null;
            string? line;

            if (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (line != null)
                    cactus = new Cactus(line);
            }

            return cactus;
        }

        public void Dispose()
        {
            if (reader != null)
            {
                reader.Close();
                reader.Dispose();
            }
        }
    }
}
