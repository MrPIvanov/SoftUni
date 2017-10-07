namespace _10_CubeProper
{
    using System;

    class StartUp
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string target = Console.ReadLine().ToLower();
            double result =0.0 ;

            switch (target)
            {
                case "face":
                    result = Math.Sqrt(2*side*side); 

                    break;

                case "space":
                    result = Math.Sqrt(3 * side * side);

                    break;

                case "volume":
                    result = side*side * side;

                    break;

                case "area":
                    result = 6*side * side;

                    break;
            }
            Console.WriteLine($"{result:f2}");




        }
    }
}