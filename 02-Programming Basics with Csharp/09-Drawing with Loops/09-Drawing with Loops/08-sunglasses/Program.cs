using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double midNumber = number;

            Console.WriteLine($"{new string('*',2*number)}{new string(' ', number)}{new string('*', 2 * number)}");

            for (int i = 2; i <= number-1; i++)
            {
                double midRow = Math.Ceiling(  midNumber / 2);

                string mid = new string(' ', number);
                if (midRow==i)
                {
                    mid = new string('|', number);
                }

                Console.WriteLine($"*{new string('/', number*2-2)}*{mid}*{new string('/', number * 2 - 2)}*");
            }







            Console.WriteLine($"{new string('*', 2 * number)}{new string(' ', number)}{new string('*', 2 * number)}");




        }
    }
}
