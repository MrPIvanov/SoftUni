using System;
using System.Linq;

namespace _03_doubleersectOfCircle
{
    public class StartUp
    {
        public static void Main()
        {
            double[] firstCircleInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] secondCircleInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Circle firstCircle = new Circle();
            Circle secondCircle = new Circle() { x = secondCircleInput[0], y = secondCircleInput[1], radius=secondCircleInput[2]};

            firstCircle.x = firstCircleInput[0];
            firstCircle.y = firstCircleInput[1];
            firstCircle.radius = firstCircleInput[2];

            double distanse = Math.Sqrt((secondCircle.x-firstCircle.x)* (secondCircle.x - firstCircle.x)+ 
                (secondCircle.y - firstCircle.y) * (secondCircle.y - firstCircle.y));


            if (firstCircle.radius+secondCircle.radius>=distanse)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    public class Circle
    {

        public double x { get; set; }
        public double y { get; set; }
        public double radius { get; set; }

    }
}