namespace _08_CenterPoin
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

            double x1y1Distance = GetTheDistanceFromACenter(x0, y0, x1, y1);
            double x2y2Distance = GetTheDistanceFromACenter(x0, y0, x2, y2);

            if (x1y1Distance<=x2y2Distance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }


        }

        static double GetTheDistanceFromACenter(double x0, double y0, double x1, double y1)
        {
            return Math.Sqrt((x1-x0)*(x1-x0)+(y1-y0)*(y1-y0));
        }
    }
}