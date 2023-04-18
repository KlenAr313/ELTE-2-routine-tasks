using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid
{
    internal class InFile
    {
        private StreamReader sr;
        private Day? day;
        private bool st;

        public InFile(string fileName)
        {
            sr = new StreamReader(fileName);
            st = false;
        }

        public Day? read()
        {
            day = null;
            if (!sr.EndOfStream)
            {
                string? s = sr.ReadLine();
                if (s != null)
                {
                    string[] line = s.Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
                    int sum = 0;
                    for (int i = 3; i < line.Length; i += 3)
                    {
                        sum += int.Parse(line[i]);
                    }
                    day = new Day(line[0], int.Parse(line[1]), sum);
                    
                }
                if (sr.EndOfStream)
                {
                    st = true;
                }
                return day;
            }
            st = true;
            return null;
        }

        public bool end()
        {
            return st;
        }
        
        public Day? current()
        {
            return day;
        }
        
        public Day? next()
        {
            return this.read();
        }

        public void Dispose()
        {
            if (sr != null)
            {
                sr.Close();
                sr.Dispose();
            }
        }
    }
}
