using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var allCars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            var currentCar = new Car(input);
            allCars.Add(currentCar);
        }

        var command = Console.ReadLine();

        if (command== "fragile")
        {
            allCars = allCars.Where(x => x.Cargo.CargoType == "fragile").Where(x=>x.Tires.Any(y=>y.Presure<1)).ToList();

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
        else
        {
            allCars = allCars.Where(x => x.Cargo.CargoType == "flamable").Where(x => x.Engine.EnginePower > 250).ToList();
            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model}");
            }
        }


    }
}