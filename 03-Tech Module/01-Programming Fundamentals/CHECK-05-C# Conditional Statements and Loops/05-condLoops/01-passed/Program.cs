using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_passed
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());

            if (number>=3.0)
            {
                Console.WriteLine($"Passed!");
            }



        }
    }
}
