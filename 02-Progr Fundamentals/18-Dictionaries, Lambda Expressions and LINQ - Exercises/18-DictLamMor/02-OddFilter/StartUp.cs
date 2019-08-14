namespace _02_OddFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> evenNumbers = new List<int>();
            evenNumbers.AddRange(numbers.FindAll(x=>x%2==0));

            double average = evenNumbers.Average();

            for (int i = 0; i < evenNumbers.Count; i++)
            {
                if (evenNumbers[i]>average)
                {
                    evenNumbers[i]++;
                }
                else
                {
                    evenNumbers[i]--;

                }
            }
            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}