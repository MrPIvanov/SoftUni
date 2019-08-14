namespace _01_SortTimes
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();

            Console.WriteLine($"{string.Join(", ", input.OrderBy(x=>x))}");


        }
    }
}