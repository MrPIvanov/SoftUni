using System;

public class StartUp
{
    static void Main()
    {
        var lenght = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var box = new Box(lenght, width, height);

        double surfaceArea =  box.CalculateSurfaceArea();
        double lateralSurfaceArea = box.CalculateLateralSurfaceArea();
        double volume = box.CalculateVolume();


        Console.WriteLine($"Surface Area - {surfaceArea:f2}");
        Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
        Console.WriteLine($"Volume - {volume:f2}");


    }
}