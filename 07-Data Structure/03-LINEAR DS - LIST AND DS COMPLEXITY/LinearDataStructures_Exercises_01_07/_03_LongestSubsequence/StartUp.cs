using System;
using System.Linq;

namespace _03_LongestSubsequence
{
    public class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var maxNumbersSequence = 0;
            var maxNumberToPrint = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentSequence = 1;
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentSequence > maxNumbersSequence)
                {
                    maxNumbersSequence = currentSequence;
                    maxNumberToPrint = numbers[i];
                }
            }

            for (int i = 0; i < maxNumbersSequence; i++)
            {
                Console.Write($"{maxNumberToPrint} ");
            }
        }
    }
}