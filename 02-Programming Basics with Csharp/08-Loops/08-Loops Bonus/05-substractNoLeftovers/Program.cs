using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_substractNoLeftovers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < numbers; i++)
            {
                double localNumber = double.Parse(Console.ReadLine());

                if (localNumber%2==0)
                {
                    p1++;
                }

                if (localNumber%3==0)
                {
                    p2++;
                }
                if (localNumber % 4 == 0)
                {
                    p3++;

                }

            }

            Console.WriteLine($"{p1/numbers*100:f2}%");
            Console.WriteLine($"{p2 / numbers * 100:f2}%");
            Console.WriteLine($"{p3 / numbers * 100:f2}%");



        }
    }
}
