namespace _07_MathPower
{
    using System;

    class StartUp
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double timesMultiplied = double.Parse(Console.ReadLine());

            double result = PowerUp(number, timesMultiplied);

            Console.WriteLine(result);

        }

        static double PowerUp(double number, double timesMultiplied)
        {
            double curentResult = 1;
            for (int i = 1; i <= timesMultiplied; i++)
            {
                curentResult*= number;
            }
            return curentResult;
        }
    }
}