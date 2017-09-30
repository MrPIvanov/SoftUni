using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number/2; i++)
            {
                Console.WriteLine($"{new string(' ',i)}x{new string(' ', number-2-(2*i))}x{new string(' ', i)}");


            }

            Console.WriteLine($"{new string(' ',number/2)}x");

            for (int i = 0; i < number/2; i++)
            {
                Console.WriteLine($"{new string(' ', number/2-i-1)}x{new string(' ', i+1+i)}x{new string(' ', number / 2 - i-1)}");
            }
        }
    }
}
