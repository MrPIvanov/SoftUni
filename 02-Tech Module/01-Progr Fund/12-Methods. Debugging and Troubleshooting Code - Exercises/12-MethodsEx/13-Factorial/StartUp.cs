namespace _13_Factorial
{
    using System.Numerics;
    using System;

    class StartUp
    {
        static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i  = 1; i <= endNumber; i++)
            {
                factorial *=i;

            }

            Console.WriteLine(factorial);
        }
    }
}