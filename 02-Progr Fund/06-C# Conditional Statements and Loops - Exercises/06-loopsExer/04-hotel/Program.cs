using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());


            double pricePerNightStudio = 1;
            double pricePerNightDouble = 1;
            double pricePerNightSuite = 1;

            double discount = 1;

            switch (month)
            {
                case "May":
                    pricePerNightStudio = 50;
                    pricePerNightDouble = 65;
                    pricePerNightSuite = 75;

                    if (nights>7)
                    {
                        pricePerNightStudio = 50 * 0.95;
                    }

                    break;

                case "October":
                    pricePerNightStudio = 50;
                    pricePerNightDouble = 65;
                    pricePerNightSuite = 75;

                    if (nights > 7)
                    {
                        pricePerNightStudio = 50 * 0.95;
                    }

                    break;

                case "June":
                    pricePerNightStudio = 60;
                    pricePerNightDouble = 72;
                    pricePerNightSuite = 82;

                    if (nights > 14)
                    {
                        pricePerNightDouble = 72 * 0.9;
                    }

                    break;

                case "September":
                    pricePerNightStudio = 60;
                    pricePerNightDouble = 72;
                    pricePerNightSuite = 82;

                    
                    if (nights>14)
                    {
                        pricePerNightDouble = 72 * 0.9;

                    }
                    if (nights > 7)
                    {
                    }

                    break;

                case "July":
                    pricePerNightStudio = 68;
                    pricePerNightDouble = 77;
                    pricePerNightSuite = 89;

                    if (nights > 14)
                    {
                        pricePerNightSuite = 89 * 0.85;
                    }

                    break;
                case "December":
                    pricePerNightStudio = 68;
                    pricePerNightDouble = 77;
                    pricePerNightSuite = 89;

                    if (nights > 14)
                    {
                        pricePerNightSuite = 89 * 0.85;
                    }

                    break;
                case "August":
                    pricePerNightStudio = 68;
                    pricePerNightDouble = 77;
                    pricePerNightSuite = 89;

                    if (nights > 14)
                    {
                        pricePerNightSuite = 89 * 0.85;
                    }

                    break;
            }

            int studioMnojitel = nights;

            if (nights>7&&(month=="September"||month=="October"))
            {
                studioMnojitel--;
            }


            Console.WriteLine($"Studio: {pricePerNightStudio*studioMnojitel:f2} lv.");
            Console.WriteLine($"Double: {pricePerNightDouble * nights:f2} lv.");
            Console.WriteLine($"Suite: {pricePerNightSuite * nights:f2} lv.");



        }
    }
}
