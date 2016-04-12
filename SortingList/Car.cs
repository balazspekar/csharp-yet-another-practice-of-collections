using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingList
{
    class Car : IComparable<Car>
    {

        public string Name { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public int CompareTo(Car other)
        {
            int compare;
            compare = String.Compare(this.Color, other.Color, true);

            if (compare == 0)
            {
                compare = this.Speed.CompareTo(other.Speed);
                compare = -compare;
            }

            return compare;
        }
    }
}

