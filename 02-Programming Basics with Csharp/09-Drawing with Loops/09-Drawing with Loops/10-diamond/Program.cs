using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("*");
            }
           else if (number == 2)
            {
                Console.WriteLine("**");
            }

            else
	        {

                int firstRowStars = 0;
                if (number % 2 != 0)
                {
                    firstRowStars = 1;
                }
                else
                {
                    firstRowStars = 2;
                }

                int rows = (number - firstRowStars) / 2;

                int secondRowLeft = ((number - 1) / 2) - 1;

                Console.WriteLine($"{new string('-', (number - 1) / 2)}{new string('*', firstRowStars)}{new string('-', (number - 1) / 2)}");

                for (int i = 1; i <= rows; i++)
                {
                    Console.WriteLine($"{new string('-', secondRowLeft)}*{new string('-', (number - secondRowLeft * 2) - 2)}*{new string('-', secondRowLeft)}");

                    secondRowLeft--;
                }
                int secondLoopRows = ((number - firstRowStars) / 2) - 1;

                for (int i = 1; i <= secondLoopRows; i++)
                {

                    Console.WriteLine($"{new string('-', i)}*{new string('-', number - i - i - 2)}*{new string('-', i)}");
                }

                Console.WriteLine($"{new string('-', (number - 1) / 2)}{new string('*', firstRowStars)}{new string('-', (number - 1) / 2)}");

            }
        }
    }
}
