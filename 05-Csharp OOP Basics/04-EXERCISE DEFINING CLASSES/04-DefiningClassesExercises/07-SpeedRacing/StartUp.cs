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
            var inputCar = Console.ReadLine().Split();
            var model = inputCar[0];
            var fuelAmount = decimal.Parse(inputCar[1]);
            var fuelConsumptionPerKilometer = decimal.Parse(inputCar[2]);
            var currentCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
            allCars.Add(currentCar);
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var Args = input.Split();
            var model = Args[1];
            var kilometersToDrive = decimal.Parse(Args[2]);

            var carToDrive = allCars.Where(x => x.Model == model).FirstOrDefault();

            carToDrive.Drive(carToDrive,kilometersToDrive);
        }

        foreach (var car in allCars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled:f0}");
        }


    }
}