using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());


            double result = Math.Round((sideA*sideB)/1000000,1);

            Console.WriteLine($"{sideA}x{sideB} => {result}MP");


        }
    }
}
