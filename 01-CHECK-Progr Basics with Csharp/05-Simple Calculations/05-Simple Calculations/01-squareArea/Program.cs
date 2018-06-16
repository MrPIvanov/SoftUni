using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_squareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The side is: ");
            int number = int.Parse(Console.ReadLine());
            int area = number * number;
            Console.WriteLine($"The area of the square is: {area}");
        }
    }
}
