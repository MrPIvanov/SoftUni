using System;
using System.Numerics;

namespace _03_BigFactorial
{
    public class StartUp
    {
        public static void Main()
        {
            var data = int.Parse(Console.ReadLine());
            BigInteger number = new BigInteger();
            number = 1;

            for (int i = 1; i <= data; i++)
            {
                number *= i;

            }

            Console.WriteLine(number);

        }
    }
}