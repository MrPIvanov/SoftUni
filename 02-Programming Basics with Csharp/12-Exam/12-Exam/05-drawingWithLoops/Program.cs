using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_drawingWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());


            double rows = 2 * number + 1;

            double colums = 2 * number + 3;

            char dot = '.';
            char asteriks = '*';


            for (int i = 0; i < (rows - 3) / 2; i++)
            {

                Console.WriteLine($"{new string(dot,i)}*{new string(dot,(int)number-i)}*{new string(dot, (int)number-i)}*{new string(dot, i)}");



            }










            Console.WriteLine($"{new string(dot, (int)(colums-5)/2)}{new string (asteriks, 5)}{new string(dot, (int)(colums - 5) / 2)}");
            Console.WriteLine($"{new string(asteriks,(int)colums)}");
            Console.WriteLine($"{new string(dot, (int)(colums - 5) / 2)}{new string(asteriks, 5)}{new string(dot, (int)(colums - 5) / 2)}");







            for (int i = 0; i < (rows - 3) / 2; i++)
            {

                Console.WriteLine($"{new string(dot,(int)number-2-i)}*{new string(dot,2+i)}*{new string(dot, 2 + i)}*{new string(dot, (int)number - 2 - i)}");


            }





        }
    }
}
