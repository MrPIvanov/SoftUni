namespace _02_MaxMethod
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

           int result = GetMaxNumber(firstNumber,secondNumber,thirdNumber);
            Console.WriteLine(result);

        }

        static int GetMaxNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber>secondNumber&&firstNumber>thirdNumber)
            {
                return firstNumber;
            }

            else if (secondNumber>firstNumber&&secondNumber>thirdNumber)
            {
                return secondNumber;
            }

            else
            {
                return thirdNumber;
            }
        }
    }
}