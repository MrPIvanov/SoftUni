namespace _06_Calculate
{
    using System;

    class StartUp
    {

        static void Main()
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = GetTriangleArea(widht, height);
            Console.WriteLine(result);



        }

        static double GetTriangleArea(double widht, double height)
        {
            return widht*height/2;

        }
    }
}