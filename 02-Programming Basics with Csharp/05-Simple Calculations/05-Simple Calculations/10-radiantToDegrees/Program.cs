using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_radiantToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls enter the angle is Radians: ");
            double radians = double.Parse(Console.ReadLine());
            double degrees = Math.Round(radians * 180 /Math.PI, 0);
            Console.WriteLine($"The result in Degrees is: {degrees}");


        }
    }
}
