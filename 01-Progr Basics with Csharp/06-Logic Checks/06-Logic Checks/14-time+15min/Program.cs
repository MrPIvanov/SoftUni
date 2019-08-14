using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int chas = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 15;


            if ((chas+1==24)&&(min>=60))
            {
                chas = -1;
            }


            if (min>=60)
            {
                chas += 1;
                min -= 60;
                if (min<10)
                {
                    Console.WriteLine($"{chas}:0{min}");

                }
                else
                {
                    Console.WriteLine($"{chas}:{min}");

                }
            }
            else
            {
                Console.WriteLine($"{chas}:{min}");
            }

            Console.ReadLine();




        }
    }
}
