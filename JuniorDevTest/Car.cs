using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorDevTest
{
    public class Car : Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Car(string name, int price, int modelYear) 
            : base(name, price, modelYear)
        {

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Price: {this.Price}:-");
            Console.WriteLine($"ModelYear: {this.ModelYear}");

            Console.WriteLine($"Number of seats: {this.NumberOfSeats}");
        }
    }
}
