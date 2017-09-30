using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2DrectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls enter the x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Pls enter the y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Pls enter the x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Pls enter the y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double oneSide = Math.Abs(x1 - x2);
            double secondSide = Math.Abs(y1 - y2);

            double area = oneSide * secondSide;
            double perimeter = 2 * (oneSide + secondSide);

            Console.WriteLine($"The area is: {area}");
            Console.WriteLine($"The perimeter is: {perimeter}");




        }
    }
}
