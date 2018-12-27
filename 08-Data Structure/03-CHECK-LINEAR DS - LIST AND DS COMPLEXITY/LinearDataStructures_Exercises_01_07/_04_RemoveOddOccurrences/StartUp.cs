using System;
using System.Linq;

namespace _04_RemoveOddOccurrences
{
    public class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                var numberOfOccurrences = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numberOfOccurrences++;
                    }
                }

                if (numberOfOccurrences % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}