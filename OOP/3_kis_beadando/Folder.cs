using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    internal class Folder: Registration
    {
        public List<Registration> items { get; set; }

        public Folder() 
        {
            items = new List<Registration>();
        }

        public void Add(Registration r)
        {
            items.Add(r);
        }

        public void Remove(Registration r)
        {
            items.Remove(r);
        }

        public override int GetSize()
        {
            int sum = 0;
            foreach (Registration r in items)
            {
                sum += r.GetSize();
            }
            return sum;
        }
    }
}
