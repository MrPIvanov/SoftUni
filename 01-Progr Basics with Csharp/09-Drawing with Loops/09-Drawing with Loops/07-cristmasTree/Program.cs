using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_cristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"{new string(' ', number+1)}|{new string(' ', number + 1)}");
            for (int row = 1; row <= number; row++)
            {
                Console.WriteLine($"{new string(' ', number-row)}{new string('*',row)} | {new string('*',row)}{new string(' ', number - row)}");
            }



        }
    }
}
