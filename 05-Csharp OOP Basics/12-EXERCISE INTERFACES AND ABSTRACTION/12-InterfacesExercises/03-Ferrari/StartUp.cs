using System;

class StartUp
{
    static void Main()
    {
        var name = Console.ReadLine();
        var car = new Ferrari(name);

        Console.WriteLine($"{car.Model}/{car.Stop()}/{car.Start()}/{car.Name}");


    }
}