using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace Fishing2
{
    public class InFile
    {
        private readonly StreamReader sr;

        public InFile(string filePath)
        {
            sr = new StreamReader(filePath);
        }

        public bool Read(out Angler? angler)
        {
            angler = null;
            string? s = sr.ReadLine();
            if(s != null)
            {
                string[] line = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                angler = new Angler(line[0]);
                for (int i = 1; i < line.Length; i++)
                {
                    Catch c = new(
                    time: line[i],
                    species: line[i+1],
                    weight: Convert.ToDouble(line[i+2]),
                    length: Convert.ToDouble(line[i+3])
                    );
                    angler.Add(c);
                }
                return true;
            }
            return false;
        }
    }
}
