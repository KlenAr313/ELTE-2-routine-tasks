using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    internal class File : Registration
    {
        public int size { get; set; }

        public File(int size)
        {
            this.size = size;
        }

        public override int GetSize()
        {
            return size;
        }
    }
}
