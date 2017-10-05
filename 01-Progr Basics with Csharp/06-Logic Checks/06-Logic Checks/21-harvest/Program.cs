using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0.4*(double.Parse(Console.ReadLine()));
            double grapes1m2 = double.Parse(Console.ReadLine());
            double needWine = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());


            double allLitres = area * grapes1m2/2.5;

            if (allLitres<needWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needWine-allLitres)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(allLitres)} liters.");
                Console.WriteLine($"{Math.Ceiling(allLitres-needWine)} liters left -> {Math.Ceiling((allLitres-needWine)/workers)} liters per person.");
            }
            

        }



    }
}
