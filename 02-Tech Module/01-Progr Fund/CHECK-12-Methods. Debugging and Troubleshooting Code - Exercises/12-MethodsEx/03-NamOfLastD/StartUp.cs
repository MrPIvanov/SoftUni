namespace _03_NamOfLastD
{
    using System;

    class StartUp
    {
        static void Main()
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));

            long lastDigit = GetTheLastDigit(number);

            string result = GetTheNameOfaDigit(lastDigit);

            Console.WriteLine(result);


        }

        static string GetTheNameOfaDigit(long lastDigit)
        {
            string[] currentLastDigitString = new string[] {"zero", "one", "two", "three", "four", "five","six", "seven", "eight", "nine"};

            return currentLastDigitString[lastDigit];

        }

        static long GetTheLastDigit(long number)
        {
            return number % 10;
        }
    }
}