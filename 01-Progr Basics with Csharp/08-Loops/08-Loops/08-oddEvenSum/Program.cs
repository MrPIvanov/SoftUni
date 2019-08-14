using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_oddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int loops = int.Parse(Console.ReadLine());

            double evenSum = 0.0;
            double oddSum = 0.0;

            for (int i = 1; i <= loops; i++)
            {
                if (i%2==0)
                {
                    double localNum = double.Parse(Console.ReadLine());

                    oddSum += localNum;
                }
                else
                {
                    double localNum = double.Parse(Console.ReadLine());

                    evenSum += localNum;
                }

            }

            if (evenSum==oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum-oddSum)}");
            }
        }
    }
}
