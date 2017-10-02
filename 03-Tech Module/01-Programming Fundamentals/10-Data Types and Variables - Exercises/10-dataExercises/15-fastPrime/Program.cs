using System;

namespace _15_fastPrime
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= number; currentNumber++)
            {
                bool isPrime = true;

                for (int curentDivider = 2; curentDivider <= Math.Sqrt(currentNumber); curentDivider++)
                {
                    if (currentNumber % curentDivider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }




        }
    }
}