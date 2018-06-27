using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        List<Car> cars = new List<Car>();
        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine();
            var currentCar = new Car(input);
            cars.Add(currentCar);
        }

        string command = Console.ReadLine();
        if (command == "fragile")
        {
            List<string> fragile = cars
                .Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(y => y.Presure < 1))
                .Select(x => x.Model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }
        else
        {
            List<string> flamable = cars
                .Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250)
                .Select(x => x.Model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }
    }

}
