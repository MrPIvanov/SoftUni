using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_rombOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           

            for (int i = 1; i <= number; i++)
            {
                Console.Write(new string(' ', number - i));
                Console.Write("*");
                for (int y = 1; y < i; y++)
                {
                    Console.Write(" *");
                }
                Console.Write(new string(' ', number - 1));
                Console.WriteLine();
                
            }

            for (int i = 1; i <= number-1; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write("*");
                for (int y = number-2; y >= i; y--)
                {
                    Console.Write(" *");
                }
                Console.Write(new string(' ', i));
                Console.WriteLine();

            }




        }
    }
}
