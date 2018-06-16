using System;
using System.Linq;

namespace _06_RectanglePosition
{
    public class StartUp
    {
        public static void Main()
        {
            var firstRectangleInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondRectangleInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            var firstRectangleTopLeft = new Point(firstRectangleInput[0], firstRectangleInput[1]);
            var firstRectangleBottomRight = new Point(firstRectangleInput[0] + firstRectangleInput[2],
                firstRectangleInput[1] + firstRectangleInput[3]);

            var firstRectangle = new Rectangle(firstRectangleTopLeft, firstRectangleBottomRight);

            var secondRectangleTopLeft = new Point(secondRectangleInput[0], secondRectangleInput[1]);
            var secondRectangleBottomRight = new Point(secondRectangleInput[0] + secondRectangleInput[2],
                secondRectangleInput[1] + secondRectangleInput[3]);

            var secondRectangle = new Rectangle(secondRectangleTopLeft, secondRectangleBottomRight);

            bool isInside = IsInside(firstRectangle, secondRectangle);
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }



        }

        private static bool IsInside(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            if (firstRectangle.TopLeft.X < secondRectangle.TopLeft.X || 
                firstRectangle.TopLeft.X > secondRectangle.BottomRight.X)
            {
                return false;
            }
            if (firstRectangle.TopLeft.Y < secondRectangle.TopLeft.Y ||
                firstRectangle.TopLeft.Y > secondRectangle.BottomRight.Y)
            {
                return false;
            }


            if (firstRectangle.BottomRight.X < secondRectangle.TopLeft.X ||
                firstRectangle.BottomRight.X > secondRectangle.BottomRight.X)
            {
                return false;
            }
            if (firstRectangle.BottomRight.Y < secondRectangle.TopLeft.Y ||
                firstRectangle.BottomRight.Y > secondRectangle.BottomRight.Y)
            {
                return false;
            }


            return true;
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x , int y)
            {
                X = x;
                Y = y;
            }
        }

        public class Rectangle
        {
            public Point TopLeft { get; set; }
            public Point BottomRight { get; set; }

            public Rectangle(Point topLeft, Point bottomRight)
            {
                TopLeft = topLeft;
                BottomRight = bottomRight;
            }
        }
    }
}