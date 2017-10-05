using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_inchToSantimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches: ");
            double inch = double.Parse(Console.ReadLine());
            double sm = 2.54 * inch;
            Console.WriteLine($"Centimeters: {sm}");
        }
    }
}
