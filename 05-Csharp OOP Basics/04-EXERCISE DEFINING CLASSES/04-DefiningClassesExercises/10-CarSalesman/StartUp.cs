using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var numberOfEngines = int.Parse(Console.ReadLine());
        var allCars = new List<Car>();
        var allEngines = new List<Engine>();

        for (int i = 0; i < numberOfEngines; i++)
        {
            var engineInput = Console.ReadLine();
            var currentEngine = new Engine(engineInput);
            allEngines.Add(currentEngine);
        }

        var numberOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCars; i++)
        {
            var carInput = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var carEngine = allEngines.Where(x => x.Model == carInput[1]).FirstOrDefault();

            var currentCar = new Car(carInput, carEngine);

            Console.WriteLine(currentCar);
        }


    }
}