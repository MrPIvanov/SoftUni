using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_areaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            if (figure=="square")
            {
                double side = double.Parse(Console.ReadLine());
                double area =Math.Round( side * side, 3);
                Console.WriteLine(area);
            }
            else if (figure=="rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double area = Math.Round(side1 * side2, 3);
                Console.WriteLine(area);
            }
            else if (figure=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.Round(Math.PI*radius*radius,3);
                Console.WriteLine(area);

            }
            else if (figure=="triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double area = Math.Round(side1*side2/2, 3);

                Console.WriteLine(area);

            }




        }
    }
}
