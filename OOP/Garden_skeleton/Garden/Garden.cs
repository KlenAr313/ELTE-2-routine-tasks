using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Garden
    {
        public class WrongParcelNumberException : Exception { }

        private readonly List<Parcel> parcels;

        public Garden(int n)
        {
            if (n <= 0) throw new WrongParcelNumberException();
            parcels = new List<Parcel>();
            for (int i = 0; i < n; ++i) parcels.Add(new Parcel());
        }

        public void Plant(int number, Plant plant, int date)
        {
            if (0 <= number && number <= parcels.Count) parcels[number].Plant(plant, date);
            else throw new WrongParcelNumberException();
        }

        public void Harvest(int number)
        {
            if (0 <= number && number <= parcels.Count) parcels[number].Harvest();
            else throw new WrongParcelNumberException();
        }

        public List<int> CanHarvest(int date)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < parcels.Count; i++)
            {
                if (parcels[i].IsRipe(date))
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
