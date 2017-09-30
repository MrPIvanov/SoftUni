using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_refactor
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfNumbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfNumbers; i++)
            {
                int curentNumber = i;
                int curentSum = 0;

                
                for (int y = 0; y < int.MaxValue; y++)
                {
                    curentSum += curentNumber % 10;

                    curentNumber /= 10;

                    if (curentNumber == 0)
                    {
                        break;
                    }
                }
                if ((curentSum == 5) || (curentSum == 7) || (curentSum == 11))
                {

                    Console.WriteLine($"{i} -> True");
                }

                else
                {
                    Console.WriteLine($"{i} -> False");

                }

            }
        }
    }
}
