namespace _09_ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var lastNumber = int.Parse(Console.ReadLine());
            var allNumbers = new List<int>();

            for (int i = 1; i <= lastNumber; i++)
            {
                allNumbers.Add(i);
            }

            var divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var number in divisors)
            {
                allNumbers = allNumbers.Where(x => x%number==0).ToList();
            }

            Console.WriteLine(string.Join(" ",allNumbers));
        }
    }
}