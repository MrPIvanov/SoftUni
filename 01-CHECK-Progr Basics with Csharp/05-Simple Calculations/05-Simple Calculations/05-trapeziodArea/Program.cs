using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_trapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls enter the first side: ");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Pls enter the second side: ");
            double secondSide = double.Parse(Console.ReadLine());
            Console.Write("Pls enter the height: ");
            double height = double.Parse(Console.ReadLine());
            double result = (firstSide + secondSide) * height / 2;
            Console.WriteLine($"The area is: {result}");


        }
    }
}
