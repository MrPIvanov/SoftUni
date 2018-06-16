namespace _01_HornetWings
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distanceInput = decimal.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var finalDistance = (wingFlaps / 1000.0m) * distanceInput;
            var timeWithoutBreaks = wingFlaps / 100.0m;
            var timeRest = (wingFlaps / endurance) * 5.0m;

            Console.WriteLine($"{finalDistance:f2} m.");
            Console.WriteLine($"{timeRest+timeWithoutBreaks:f0} s.");


        }
    }
}