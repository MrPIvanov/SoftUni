using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int firstRow = (int)(((2*number)-1)-3)/2;

            Console.WriteLine($"@{new string(' ', firstRow)}@{new string(' ', firstRow)}@");
            Console.WriteLine($"**{new string(' ', firstRow-1)}*{new string(' ', firstRow-1)}**");

            int sumbolsOnRow = (int)(2*number)-1;
            int rows = (int)(number / 2)+4-3;


            char asteriks = '*';
            char space = ' ';
            char dot = '.';
            int spaceNumber = firstRow-3;
            int dotNumberMiddle = 0;

            int normalDots = 1;


            for (int i = 1; i <= rows-3; i++)
            {

                
                
                    Console.WriteLine($"*{new string(dot,normalDots)}*{new string(space,spaceNumber)}*{new string(dot, normalDots+dotNumberMiddle)}*{new string(space, spaceNumber)}*{new string(dot, normalDots)}*");
                

                dotNumberMiddle++;
                spaceNumber -= 2;
                normalDots++;
                
            }


            Console.WriteLine($"*{new string(dot,normalDots)}*{new string(dot, normalDots+dotNumberMiddle)}*{new string(dot, normalDots)}*");
            normalDots++;

            int asteriksNumberHere =(int)(((2*number)-1)-3-(2*normalDots))/2;

            Console.WriteLine($"*{new string(dot,normalDots)}{new string(asteriks,asteriksNumberHere)}.{new string(asteriks,asteriksNumberHere)}{new string(dot, normalDots)}*");

            Console.WriteLine($"{new string('*', (int)(2*number)-1)}");
            Console.WriteLine($"{new string('*', (int)(2 * number) - 1)}");






        }
    }
}
