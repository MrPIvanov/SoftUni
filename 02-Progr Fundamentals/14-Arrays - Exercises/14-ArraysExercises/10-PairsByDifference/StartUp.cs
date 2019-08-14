namespace _10_PairsByDifference
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diffrence = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int y = i; y < numbers.Length; y++)
                {
                    if (Math.Abs(numbers[i] - numbers[y])==diffrence)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}