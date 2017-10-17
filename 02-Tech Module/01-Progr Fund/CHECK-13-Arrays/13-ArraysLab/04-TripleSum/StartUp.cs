namespace _04_TripleSum
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long currentSum = 0;
            bool printNo = true;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int y = 1+i; y < numbers.Length; y++)
                {
                    currentSum = numbers[i] + numbers[y];

                    if (numbers.Contains(currentSum))
                    {
                        printNo = false;
                        Console.WriteLine($"{numbers[i]} + {numbers[y]} == {currentSum}");
                    }
                }
            }

            if (printNo)
            {
                Console.WriteLine("No");
            }
        }
    }
}