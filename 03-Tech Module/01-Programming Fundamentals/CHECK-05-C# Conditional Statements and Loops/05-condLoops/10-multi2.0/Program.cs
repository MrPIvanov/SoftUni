using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_multiplic
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multi = int.Parse(Console.ReadLine());

            if (multi>10)
            {
                Console.WriteLine($"{number} X {multi} = {number * multi}");
            }

            else
            {
                for (int i = multi; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
            




        }
    }
}
