using System;

public class StartUp
{
    static void Main()
    {
        var carInfo = Console.ReadLine().Split();
        var truckInfo = Console.ReadLine().Split();
        var busInfo = Console.ReadLine().Split();


        var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
        var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
        var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var tokens = Console.ReadLine().Split();

            var command = tokens[0];
            var vehicle = tokens[1];
            var amount = double.Parse(tokens[2]);

            if (vehicle == "Car")
            {
                if (command == "Drive")
                {
                    car.Drive(amount);
                }
                else
                {
                    car.Refil(amount);
                }
            }
            else if (vehicle == "Truck")
            {
                if (command == "Drive")
                {
                    truck.Drive(amount);
                }
                else
                {
                    truck.Refil(amount);
                }
            }

            else
            {
                if (command == "Drive")
                {
                    bus.Drive(amount);
                }

                else if (command == "DriveEmpty")
                {
                    bus.DriveEmpty(amount);
                }

                else
                {
                    bus.Refil(amount);
                }
            }
        }

        Console.WriteLine($"Car: {car.FuelQuantity:f2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");

    }
}