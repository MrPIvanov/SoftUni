namespace _04_Largest3Nums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).ToList();

            if (numbers.Count<=3)
            {
                Console.WriteLine($"{string.Join(" ", numbers)}");
            }

            else
            {
                Console.WriteLine($"{string.Join(" ", numbers.Take(3))}");
            }
        }
    }
}