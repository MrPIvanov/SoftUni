using System;

namespace _05_weather
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();

            string weather = "";

            try
            {
                decimal currentNumber = decimal.Parse(number);
                weather = "Rainy";
            }

            catch
            {
            }

            try
            {
                long currentNumber = long.Parse(number);
                weather = "Windy";
            }

            catch
            {
            }

            try
            {
                int currentNumber = int.Parse(number);
                weather = "Cloudy";
            }

            catch
            {
            }

            try
            {
                sbyte currentNumber = sbyte.Parse(number);
                weather = "Sunny";
            }

            catch
            {
            }
            Console.WriteLine(weather);
        }
    }
}