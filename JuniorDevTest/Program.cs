using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorDevTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Volvo XC60", 600000, 2021);
            Car c2 = new Car("Audi A4", 375000, 2020);
            Car c3 = new Car("Toyota Yaris", 140000, 2017);

            Console.WriteLine("Car data: ");
            c1.DisplayInfo();
            c2.DisplayInfo();
            c3.DisplayInfo();


            Clock clock = new Clock();
            clock.DisplayTimeNow();

            Console.ReadLine();
        }
    }
}
