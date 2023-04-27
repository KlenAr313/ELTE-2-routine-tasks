using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Parcel
    {
        public class NotEmptyParcelException : Exception { }

        public int PlantingDate { get; private set; }
        public Plant? Content { get; private set; }

        public Parcel() { Content = null; }

        public void Plant(Plant plant, int date)
        {
            if(Content != null)
            {
                throw new NotEmptyParcelException();
            }
            PlantingDate = date;
            Content = plant;
        }

        public bool IsRipe(int date)
        {
            if(Content != null && Content.IsVegetable() && date < PlantingDate + Content.RipeningTime)
            {
                return true;
            }
            return false;
        }

        public void Harvest() { Content = null; }
    }
}
