using System;

namespace _11_speedUnits
{
    class Program
    {
        static void Main(string[] args)
        {

            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());


            float metrePerSec = distanceInMeters/((hours*60*60)+(minutes*60)+(seconds));
            float kilometersPerSec = (distanceInMeters/1000)/((hours)+(minutes/60)+(seconds/60/60));
            float milesPerSec = (distanceInMeters / 1609) / ((hours) + (minutes / 60) + (seconds / 60 / 60));

            Console.WriteLine(metrePerSec);
            Console.WriteLine(kilometersPerSec);
            Console.WriteLine(milesPerSec);

        }
    }
}