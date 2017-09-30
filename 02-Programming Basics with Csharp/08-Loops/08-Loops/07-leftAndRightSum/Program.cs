using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_leftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double firstSum = 0.0;
            double secondSum = 0.0;

            for (int i = 0; i < numbers; i++)
            {
                double localNumber = double.Parse(Console.ReadLine());

                firstSum += localNumber;
            }
            for (int i = 0; i < numbers; i++)
            {
                double localNumber = double.Parse(Console.ReadLine());

                secondSum += localNumber;
            }

            if (firstSum==secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");
            }

            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(firstSum-secondSum)}");
            }
        }
    }
}
