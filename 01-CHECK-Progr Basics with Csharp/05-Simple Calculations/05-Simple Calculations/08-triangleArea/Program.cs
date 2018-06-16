using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_triangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = double.Parse(Console.ReadLine());

            double area = Math.Round(side * height / 2, 2);

            Console.WriteLine($"The area is: {area}");

        }
    }
}
