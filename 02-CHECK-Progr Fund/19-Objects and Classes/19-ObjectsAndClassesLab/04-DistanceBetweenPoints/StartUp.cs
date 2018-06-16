using System;

namespace _04_DistanceBetweenPoints
{
    public class StartUp
    {
        public static void Main()
        {
            var firstPointInput = Console.ReadLine().Split();
            var secondPointInput = Console.ReadLine().Split();

            var x1 = int.Parse(firstPointInput[0]);
            var y1 = int.Parse(firstPointInput[1]);

            var x2 = int.Parse(secondPointInput[0]);
            var y2 = int.Parse(secondPointInput[1]);


            var firstPoint = new Point(x1, y1);
            var secondPoint = new Point(x2, y2);

            double result = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");

        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double result;

            result = Math.Sqrt((firstPoint.X-secondPoint.X)* (firstPoint.X - secondPoint.X) + 
                (firstPoint.Y - secondPoint.Y)*(firstPoint.Y - secondPoint.Y));

            return result;
        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}