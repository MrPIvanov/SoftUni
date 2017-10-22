namespace _06_SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {

                if (Math.Sqrt(numbers[i])==(int)(Math.Sqrt(numbers[i])))
                {
                    result.Add(numbers[i]);
                }


            }

            result.Sort((a,b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", result));

        }
    }
}