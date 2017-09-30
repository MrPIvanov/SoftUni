using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_tubesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double tube1 = double.Parse(Console.ReadLine());
            double tube2 = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double allWater = tube1 * hours + tube2 * hours;

            if (allWater<volume)
            {
                Console.WriteLine($"The pool is {Math.Floor(allWater/volume*100)}% full. Pipe 1: {Math.Floor(tube1/allWater*100*hours)}%. Pipe 2: {Math.Floor(tube2/allWater*100*hours)}%.");
            }
            else if (allWater>volume)
            {
                double overWater = Math.Round(allWater - volume, 1);
                Console.WriteLine($"For {Math.Round(hours,1)} hours the pool overflows with {overWater:f1} liters.");
            }


        }
    }
}
