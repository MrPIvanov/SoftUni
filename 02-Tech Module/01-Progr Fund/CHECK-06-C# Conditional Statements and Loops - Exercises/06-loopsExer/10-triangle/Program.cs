using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {

                for (int y = 0; y < i; y++)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();


            }





        }
    }
}
