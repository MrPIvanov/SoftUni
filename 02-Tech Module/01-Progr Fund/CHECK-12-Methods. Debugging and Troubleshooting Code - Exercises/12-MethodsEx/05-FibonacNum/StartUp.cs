namespace _05_FibonacNum
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetFibonacci(number);

            Console.WriteLine(result);
        }

        static int GetFibonacci(int number)
        {
            int firstNumber = 1;
            int secondNumber = 2;

            for (int i = 3; i <= number; i++)
            {
                int currentNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = currentNumber;
            }
            if (number==0)
            {
                return 1;
            }
            if (number==1)
            {
                return 1;
            }
            if (number==2)
            {
                return 2;
            }
            return secondNumber;

        }
    }
}