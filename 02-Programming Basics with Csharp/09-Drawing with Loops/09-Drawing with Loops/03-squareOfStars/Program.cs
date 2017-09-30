using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_squareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
                for (int y = 1; y < number; y++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                
            }


        }
    }
}
