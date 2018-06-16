namespace _08_MostFrequentNumber
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] allNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int endCounter = 0;
            int endPosition = 0;

            int newCounter = 0;

            for (int i = 0; i < allNumbers.Length; i++)
            {
                for (int y = 0; y < allNumbers.Length; y++)
                {
                    if (allNumbers[i]==allNumbers[y])
                    {
                        newCounter++;
                    }

                    if (newCounter>endCounter)
                    {
                        endCounter = newCounter;
                        endPosition = i;
                    }
                }
                newCounter = 0;
            }
            Console.WriteLine(allNumbers[endPosition]);

        }
    }
}