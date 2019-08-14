using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_squareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', number));
            for (int i = 1; i <= number-2; i++)
            {
                Console.WriteLine($"*{new string(' ', number-2)}*");
            }
            Console.WriteLine(new string('*', number));

        }
    }
}
