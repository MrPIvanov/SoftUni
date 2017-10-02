using System;

namespace _12_rectangleP
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine($"{sideA+sideA+sideB+sideB}");
            Console.WriteLine($"{sideB*sideA}");
            Console.WriteLine($"{Math.Sqrt(sideA*sideA+sideB*sideB)}");






        }
    }
}