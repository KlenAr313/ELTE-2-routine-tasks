using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus
{
    internal class Cactus
    {
        public string name { get; set; }
        public string colour { get; set; }
        public string homeland { get; set; }
        public int size { get; set; }

        public Cactus(string s)
        {
            string[] sections = s.Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            switch (sections.Length)
            {
                case 0:
                    this.name = "none";
                    this.colour = "none";
                    this.homeland = "none";
                    this.size = 0;
                    break;
                case 1:
                    this.name = sections[0];
                    this.colour = "none";
                    this.homeland = "none";
                    this.size = 0;
                    break;
                case 2:
                    this.name = sections[0];
                    this.colour = sections[1];
                    this.homeland = "none";
                    this.size = 0;
                    break;
               case 3:
                    this.name = sections[0];
                    this.colour = sections[1];
                    this.homeland = sections[2];
                    this.size = 0;
                    break;
                default:
                    this.name = sections[0];
                    this.colour = sections[1];
                    this.homeland = sections[2];
                    this.size = Convert.ToInt32(sections[3]);
                    break;
            }
        }
    }
}
