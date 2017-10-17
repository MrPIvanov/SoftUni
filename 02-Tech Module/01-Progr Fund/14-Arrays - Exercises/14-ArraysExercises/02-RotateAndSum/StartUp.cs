namespace _02_RotateAndSum
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] startingNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int[] sumResult = new int[startingNumbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = startingNumbers[startingNumbers.Length - 1];

                for (int e = startingNumbers.Length - 1; e > 0; e--)
                {
                    startingNumbers[e] = startingNumbers[e - 1];
                }

                startingNumbers[0] = lastElement;

                for (int w = 0; w < startingNumbers.Length; w++)
                {
                    sumResult[w] += startingNumbers[w];
                }
            }
            Console.WriteLine(string.Join(" ", sumResult));

        }
    }
}