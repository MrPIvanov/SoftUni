namespace _05_Temperatu
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            double tempInFahrenheit = double.Parse(Console.ReadLine());

            double celsius = FahrenheitToCelsius(tempInFahrenheit);

            Console.WriteLine($"{celsius:f2}");


        }

        static double FahrenheitToCelsius(double temp)
        {
            return ((temp - 32) * 5 / 9);


        }
    }
}