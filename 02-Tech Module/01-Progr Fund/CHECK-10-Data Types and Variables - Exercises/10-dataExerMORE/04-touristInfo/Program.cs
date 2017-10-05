using System;

namespace _04_touristInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();

            double quantity = double.Parse(Console.ReadLine());


            switch (type)
            {
                case "miles":

                    Console.WriteLine($"{quantity} miles = {quantity*1.6:f2} kilometers");

                    break;

                case "inches":

                    Console.WriteLine($"{quantity} inches = {(quantity * 2.54d):f2} centimeters");

                    break;

                case "feet":

                    Console.WriteLine($"{quantity} feet = {(quantity * 30d):f2} centimeters");

                    break;

                case "yards":

                    Console.WriteLine($"{quantity} yards = {(quantity * 0.91d):f2} meters");

                    break;

                case "gallons":

                    Console.WriteLine($"{quantity} gallons = {(quantity * 3.8d):f2} liters");

                    break;




            }






        }
    }
}