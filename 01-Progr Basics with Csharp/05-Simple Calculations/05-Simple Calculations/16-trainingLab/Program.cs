using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_trainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of the room: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the room: ");
            double width = double.Parse(Console.ReadLine());
            //if (3<=width && width<=height && height<=100)
            //{

            //    double mesta = Math.Floor(height / 1.2);
            //    double reda = Math.Floor((width-1)/0.7);
            //    double result = mesta * reda - 3;
            //    Console.WriteLine($"We can make {result} seats in the room");


            //}
            //else
            //{
            //    Console.WriteLine("You enter wrong numbers. Pls try again!");
            //}
            double mesta = Math.Floor(height / 1.2);
            double reda = Math.Floor((width - 1) / 0.7);
            double result = mesta * reda - 3;
            Console.WriteLine($"We can make {result} seats in the room");

            Console.ReadLine();

        }
    }
}
