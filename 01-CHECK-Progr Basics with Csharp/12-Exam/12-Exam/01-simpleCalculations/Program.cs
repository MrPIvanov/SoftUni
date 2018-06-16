using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_simpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfRectangleTables = double.Parse(Console.ReadLine());
            double longOfTheTables = double.Parse(Console.ReadLine());
            double weightOfTheTables = double.Parse(Console.ReadLine());



            double kareArea = ((longOfTheTables / 2) * (longOfTheTables / 2))*numberOfRectangleTables;

            double pokrivkaArea = ((longOfTheTables + 0.6) * (weightOfTheTables+0.6))*numberOfRectangleTables;

            double resultUSD = kareArea*9+pokrivkaArea*7;
            double resultBGN = resultUSD*1.85;

            Console.WriteLine($"{resultUSD:f2} USD");
            Console.WriteLine($"{resultBGN:f2} BGN");

        }
    }
}
