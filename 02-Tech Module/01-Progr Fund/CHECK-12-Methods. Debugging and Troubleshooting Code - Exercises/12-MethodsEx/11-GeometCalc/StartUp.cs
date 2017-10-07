namespace _11_GeometCalc
{
 using System;

    class StartUp
    {
        static void Main()
        {
            string figure = Console.ReadLine().ToLower();

            switch (figure)
            {
                case "triangle":

                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());

                    double area = (side * height) / 2;
                    Console.WriteLine($"{area:f2}");

                    break;

                case "square":

                    double sideSquare = double.Parse(Console.ReadLine());

                    double areaSquare = sideSquare *sideSquare;
                    Console.WriteLine($"{areaSquare:f2}");

                    break;

                case "rectangle":

                    double width = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());

                    double areaRectangle = width*heightRectangle;
                    Console.WriteLine($"{areaRectangle:f2}");

                    break;

                case "circle":

                    double radius = double.Parse(Console.ReadLine());

                    double areaCircle =Math.PI*radius*radius;
                    Console.WriteLine($"{areaCircle:f2}");

                    break;
            }


        }
    }
}