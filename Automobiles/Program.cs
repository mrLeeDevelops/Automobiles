using System;
using System.Collections.Generic;

namespace Automobiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var caddy = new Car();
            caddy.Make = "Cadillac";
            caddy.Model = "El Dorado";
            caddy.Year = 2000;

            var prelude = new Car()
            {
                Make = "Honda",
                Model = "Prelude",
                Year = 2001
            };

            var myCar = new Car("Toyota", "camry", 2012);

            var carList = new List<Car>() { caddy, prelude, myCar };
            
            foreach ( var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}");

            }
            
        }
    }
}
