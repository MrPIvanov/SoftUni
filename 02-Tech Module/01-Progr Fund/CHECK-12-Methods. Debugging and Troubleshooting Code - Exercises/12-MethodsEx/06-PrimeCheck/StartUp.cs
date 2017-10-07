namespace _06_PrimeCheck
{
    using System;

    class StartUp
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            bool result = ItIsPrimeChecker(number);

            Console.WriteLine(result);
        }

        static bool ItIsPrimeChecker(long number)
        {
            if (number == 0||number==1)
            {
                return false;
            }
            
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}