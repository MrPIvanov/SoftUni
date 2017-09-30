using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"What is the ''r'' of the circle?: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            double Perimeter = 2 * radius * Math.PI;
            Console.WriteLine($"The area of the circle is: {area}");
            Console.WriteLine($"The perimeter of the circle is: {Perimeter}");

        }
    }
}
