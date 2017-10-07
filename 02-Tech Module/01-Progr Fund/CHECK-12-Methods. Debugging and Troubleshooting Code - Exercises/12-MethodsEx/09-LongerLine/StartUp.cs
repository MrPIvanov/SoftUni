namespace _09_LongerLine
{
    using System;

    class StartUp
    {
        static void Main()
        {
            double x0 = 0;
            double y0 = 0;
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double x1y1Distance = GetTheDistanceFromACenter(x0, y0, x1, y1);
            double x2y2Distance = GetTheDistanceFromACenter(x0, y0, x2, y2);
            double x3y3Distance = GetTheDistanceFromACenter(x0, y0, x3, y3);
            double x4y4Distance = GetTheDistanceFromACenter(x0, y0, x4, y4);

            double lenghtOfFirstCouple = GetTheDistanceFromACenter(x1, y1, x2, y2);
            double lenghtOfSecondCouple = GetTheDistanceFromACenter(x3, y3, x4, y4);

            if (lenghtOfFirstCouple>=lenghtOfSecondCouple)
            {
                if (x1y1Distance<=x2y2Distance)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");

                }
            }
            else
            {
                if (x3y3Distance <= x4y4Distance)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");

                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");

                }
            }

        }

        static double GetTheDistanceFromACenter(double x0, double y0, double x1, double y1)
        {
            return Math.Sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0));
        }
    }
}