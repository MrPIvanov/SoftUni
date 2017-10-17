namespace _05_RoundingNumbersAwayFromZero
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");

            }




        }
    }
}