using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_ClosestTwoPoints
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            var allPoints = new List<Point>();

            for (int i = 0; i < numberOfPoints; i++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToList();
                var x = line[0];
                var y = line[1];

                var tempPoint = new Point(x, y);

                allPoints.Add(tempPoint);
            }

            double endResult = double.MaxValue;
            var firstPoint = new Point();
            var secondPoint = new Point();

            for (int i = 0; i < allPoints.Count; i++)
            {
                for (int t = i + 1; t < allPoints.Count; t++)
                {
                    var tempResult = CalcDistance(allPoints[i], allPoints[t]);

                    if (tempResult < endResult)
                    {
                        endResult = tempResult;
                        firstPoint = allPoints[i];
                        secondPoint = allPoints[t];
                    }
                }
            }
            Console.WriteLine($"{endResult:f3}");
            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double result;

            result = Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
                (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y));

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
        public Point()
        {

        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}