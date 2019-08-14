namespace _01_CountRealNums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {

            var numbers = new SortedDictionary<double, int>();

            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (numbers.ContainsKey(input[i]))
                {
                    numbers[input[i]]++;
                }
                else
                {
                    numbers[input[i]] = 1;

                }

            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}