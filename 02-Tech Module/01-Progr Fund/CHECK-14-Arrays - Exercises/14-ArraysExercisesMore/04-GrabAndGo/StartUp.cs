namespace _04_GrabAndGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();

            long finalNumber = long.Parse(Console.ReadLine());

            long finalPosition = numbers.FindLastIndex(x=>x==finalNumber);

            if (finalPosition==-1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                long result = numbers.Take((int)finalPosition).Sum();
                Console.WriteLine(result);
            }
        }
    }
}