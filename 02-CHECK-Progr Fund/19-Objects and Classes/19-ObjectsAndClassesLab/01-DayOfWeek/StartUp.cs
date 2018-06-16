using System;
using System.Globalization;

namespace _01_DayOfWeek
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var inputData = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(inputData.DayOfWeek);



        }
    }
}