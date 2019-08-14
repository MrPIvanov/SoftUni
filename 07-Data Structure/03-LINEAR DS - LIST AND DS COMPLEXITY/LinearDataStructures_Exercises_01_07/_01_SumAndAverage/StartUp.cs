using System;
using System.Linq;

namespace _01_SumAndAverage
{
    public class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var average = numbers.Average();

            var sum = numbers.Sum();

            Console.WriteLine($"Sum={sum}; Average={average:f2}");
        }
    }
}