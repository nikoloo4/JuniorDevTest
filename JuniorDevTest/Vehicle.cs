using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorDevTest
{
    public abstract class Vehicle
    {
        public string Name;
        public int Price;
        public int ModelYear;

        public Vehicle(string name, int price, int modelYear)
        {
            Name = name;
            Price = price;
            ModelYear = modelYear;
        }
        public abstract void DisplayInfo();


    }
}
