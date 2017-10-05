using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_house
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double doubleNumber = number;

            double roofRows = Math.Floor((doubleNumber+1)/2);

            int firstRowStars = 0;

            if (number%2!=0)
            {
                firstRowStars = 1;
            }
            else
            {
                firstRowStars = 2;

            }

            for (int i = 1; i <= roofRows; i++)
            {
                Console.WriteLine($"{new string('-',(number-firstRowStars)/2)}{new string('*', firstRowStars)}{new string('-', (number - firstRowStars) / 2)}");

                firstRowStars += 2;
            }

            double houseRows = Math.Floor(doubleNumber / 2);

            for (int i = 1; i <= houseRows; i++)
            {
                Console.WriteLine($"|{new string('*', number-2)}|");
            }

        }
    }
}
