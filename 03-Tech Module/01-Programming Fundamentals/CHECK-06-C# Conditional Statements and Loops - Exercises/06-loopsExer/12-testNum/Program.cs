using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_testNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int testSum = 0;
            int combinations = 0;

            for (int i = firstNumber; i >= 1; i--)
            {

                for (int y = 1; y <= secondNumber; y++)
                {

                    int curentNumber = 3 * (i*y);


                    if (testSum >= maxSum)
                    {
                        break;
                    }

                    testSum += curentNumber;
                    combinations++;

                   


                }



            }


            if (testSum>=maxSum)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {testSum} >= {maxSum}");
            }

            else
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {testSum}");
            }


        }
    }
}
