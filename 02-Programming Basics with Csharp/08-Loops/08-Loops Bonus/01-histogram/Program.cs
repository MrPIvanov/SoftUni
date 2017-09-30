using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 1; i <= numbers; i++)
            {
                int localNumber = int.Parse(Console.ReadLine());

                if (localNumber < 200)
                {
                    p1++;
                }
                else if (localNumber < 400)
                {
                    p2++;
                }
                else if (localNumber < 600)
                {
                    p3++;
                }
                else if (localNumber < 800)
                {
                    p4++;
                }
                else if (localNumber >=800)
                {
                    p5++;
                }

            }

            Console.WriteLine($"{100*(p1/numbers):f2}");
            Console.WriteLine($"{100 * (p2 / numbers):f2}");
            Console.WriteLine($"{100 * (p3 / numbers):f2}");
            Console.WriteLine($"{100 * (p4 / numbers):f2}");
            Console.WriteLine($"{100 * (p5 / numbers):f2}");




        }
    }
}
