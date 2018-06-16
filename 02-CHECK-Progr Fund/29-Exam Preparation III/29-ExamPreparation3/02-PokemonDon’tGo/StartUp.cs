namespace _02_PokemonDon_tGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allNumbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            long resultSum = 0;
            long currentNumber = 0;

            while (allNumbers.Count>0)
            {
                var currentIndexInput = int.Parse(Console.ReadLine());

                if (currentIndexInput<0)
                {
                    if (allNumbers.Count>1)
                    {
                        currentNumber = allNumbers.First();
                        resultSum += currentNumber;
                        allNumbers[0] = allNumbers.Last();

                        IncreaseAndDecreaseAllNumbers(allNumbers,currentNumber);
                    }
                    else
                    {
                        currentNumber = allNumbers.First();
                        resultSum += currentNumber;
                        break;
                    }
                }
                else if (currentIndexInput>allNumbers.Count-1)
                {
                    if (allNumbers.Count > 1)
                    {
                        currentNumber = allNumbers.Last();
                        resultSum += currentNumber;
                        allNumbers[allNumbers.Count-1] = allNumbers.First();

                        IncreaseAndDecreaseAllNumbers(allNumbers, currentNumber);

                    }
                    else
                    {
                        currentNumber = allNumbers.Last();
                        resultSum += currentNumber;
                        break;
                    }
                }
                else
                {
                    currentNumber = allNumbers[currentIndexInput];

                    resultSum += currentNumber;
                    allNumbers.RemoveAt(currentIndexInput);

                    IncreaseAndDecreaseAllNumbers(allNumbers, currentNumber);

                }
            }

            Console.WriteLine(resultSum);
        }

        private static void IncreaseAndDecreaseAllNumbers(List<long> allNumbers, long currentNumber)
        {
            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (allNumbers[i] <= currentNumber)
                {
                    allNumbers[i] += currentNumber;

                }
                else
                {
                    allNumbers[i] -= currentNumber;
                }

            }
        }
    }
}