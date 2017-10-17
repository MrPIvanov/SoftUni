namespace _01_MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int counter = 1;
            int maxCounter = 1;
            int positionToPrint = 0;


            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    counter++;
                }

                else
                {
                    counter = 1;
                }

                if (counter>maxCounter)
                {
                    maxCounter = counter;
                    positionToPrint = i;
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{numbers[positionToPrint]} ");
            }

        }
    }
}