namespace _07_CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> result = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (result.ContainsKey(numbers[i]))
                {
                    result[numbers[i]]++;
                }
                else
                {
                    result[numbers[i]] = 1;

                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}