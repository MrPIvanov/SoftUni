using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_celsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plse enter the tempreture in C : ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 9 / 5 + 32;
            Console.WriteLine($"The temperature in F is: {f}");



        }
    }
}
