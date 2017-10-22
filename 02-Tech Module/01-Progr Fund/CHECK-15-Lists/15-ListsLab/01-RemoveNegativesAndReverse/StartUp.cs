namespace _01_RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> temp = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]>0)
                {
                    temp.Add(numbers[i]);
                }

            }

            temp.Reverse();

            if (temp.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var item in temp)
                {
                    Console.Write($"{item} ");
                }
            }
           
        }
    }
}