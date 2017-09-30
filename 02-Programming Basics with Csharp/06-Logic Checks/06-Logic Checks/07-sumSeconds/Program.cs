using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_sumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int allSeconds = first + second + third;

            if (allSeconds<10)
            {
                Console.WriteLine($"0:0{allSeconds}");
            }
            else if (allSeconds<60)
            {
                Console.WriteLine($"0:{allSeconds}");
            }
            else if (allSeconds<70)
            {
                allSeconds -= 60;
                Console.WriteLine($"1:0{allSeconds}");
            }
            else if (allSeconds<120)
            {
                allSeconds -= 60;
                Console.WriteLine($"1:{allSeconds}");
            }
            else if (allSeconds<130)
            {
                allSeconds -= 120;
                Console.WriteLine($"2:0{allSeconds}");

            }
            else
            {
                allSeconds -= 120;
                Console.WriteLine($"2:{allSeconds}");
            }





        }
    }
}
