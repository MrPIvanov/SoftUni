namespace _07_PrimeInRan
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = startNumber; i <= endNumber; i++)
            {
                bool isPrime = PrimeChecker(i);

                if (isPrime)
                {
                    result += ($"{i}, ");
                }
            }

            result = result.Remove(result.Length - 2, 2);
            Console.WriteLine(result);
        }

        static bool PrimeChecker(int i)
        {
            if (i == 0 || i == 1)
            {
                return false;
            }

            for (int y = 2; y <= Math.Sqrt(i); y++)
            {
                if (i%y==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}