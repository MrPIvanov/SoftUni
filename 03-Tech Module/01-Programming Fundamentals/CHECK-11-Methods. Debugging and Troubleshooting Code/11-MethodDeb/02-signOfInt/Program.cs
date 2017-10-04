using System;

namespace _02_signOfInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintSign(number);

        }

        static void PrintSign(int number)
        {

            if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }

            else if (number==0)
            {
                Console.WriteLine($"The number {number} is zero.");

            }
            else
            {
                Console.WriteLine($"The number {number} is positive.");

            }

        }
    }
}