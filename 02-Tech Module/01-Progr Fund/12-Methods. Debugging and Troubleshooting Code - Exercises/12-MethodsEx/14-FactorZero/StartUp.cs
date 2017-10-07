namespace _14_FactorZero
{
    using System;
    using System.Numerics;

    class StartUp
    {
        static void Main()
        {

            int endNumber = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= endNumber; i++)
            {
                factorial *= i;

            }

            int zeroes = CounterOfZeroes(factorial);

            Console.WriteLine(zeroes);

            //Console.WriteLine($"{endNumber}! = {factorial} -> {zeroes} trailing zero");
        }

        static int CounterOfZeroes(BigInteger factorial)
        {
            int counter = 0;
            string factorialString = factorial.ToString();

            for (int i = 1; i <= factorialString.Length; i++)
            {
                if (factorialString.EndsWith("0"))
                {
                    counter++;
                    factorialString = factorialString.Remove(factorialString.Length-1,1);

                    continue;
                }


                break;

            }

            return counter;
        }
    }
}