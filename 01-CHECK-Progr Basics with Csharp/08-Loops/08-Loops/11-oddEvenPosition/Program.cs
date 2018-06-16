using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_oddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = 10000000;
            double oddMax = -10000000;
            double evenSum = 0.0;
            double evenMin = 10000000;
            double evenMax = -10000000;

            for (int i = 1; i <= loops; i++)
            {
                if (i%2==0)
                {
                    double localNumber = double.Parse(Console.ReadLine());

                    evenSum += localNumber;

                    if (localNumber>evenMax)
                    {
                        evenMax = localNumber;
                    }
                    if (localNumber<evenMin)
                    {
                        evenMin = localNumber;
                    }
                }
                else if (i % 2 != 0)
                {
                    double localNumber = double.Parse(Console.ReadLine());

                    oddSum += localNumber;

                    if (localNumber > oddMax)
                    {
                        oddMax = localNumber;
                    }
                    if (localNumber < oddMin)
                    {
                        oddMin = localNumber;
                    }
                }



            }

            Console.WriteLine($"OddSum={oddSum},");
            if (oddMin==10000000)
            {
                Console.WriteLine("OddMin=No,");
            }
            else 
            {
                Console.WriteLine($"OddMin={oddMin},");
            }
            if (oddMax == -10000000)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax},");
            }
            Console.WriteLine($"EvenSum={evenSum},");

            if (evenMin == 10000000)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin},");
            }
            if (evenMax == -10000000)
            {
                Console.WriteLine("EvenMax=No,");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax}");
            }

        }
    }
}
