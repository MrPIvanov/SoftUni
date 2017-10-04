namespace _09_MultiplyE
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipliedOddsAndEvenNmbers(number);

            Console.WriteLine(result);

        }

        static int GetMultipliedOddsAndEvenNmbers(int number)
        {
            number = Math.Abs(number);
            int oddSum = 0;
            int evenSum = 0;

            while (number>0)
            {
                int curentLetter = number % 10;
                if (curentLetter%2==0)
                {
                    evenSum += curentLetter;
                }
                else
                {
                    oddSum += curentLetter;
                }
                number /= 10;
            }

            return oddSum * evenSum;
        }
    }
}