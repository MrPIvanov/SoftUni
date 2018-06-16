namespace _03_SumMinMaxAvera
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            double lines = double.Parse(Console.ReadLine());
            var numbers = new List<double>().ToList();

            for (double i = 0; i < lines; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                numbers.Add(currentNumber);

            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");



        }
    }
}