using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            double nights = double.Parse(Console.ReadLine());

            double studioPrice = 0.00;
            double apartmentPrice = 0.00;


            switch (month)
            {
                case "may":
                    studioPrice = 50 * nights;
                    apartmentPrice = 65 * nights;
                    if (nights>7&&nights<=14)
                    {
                        studioPrice *=0.95;
                    }
                    else if (nights>14)
                    {
                        studioPrice *=0.7;
                    }
                    break;
                case "june":
                    studioPrice = 75.20 * nights;
                    apartmentPrice = 68.70 * nights;
                    if (nights > 14)
                    {
                        studioPrice *= 0.8;
                    }
                    break;
                case "july":
                    studioPrice = 76 * nights;
                    apartmentPrice = 77 * nights;
                    break;
                case "august":
                    studioPrice = 76 * nights;
                    apartmentPrice = 77 * nights;
                    break;
                case "september":
                    studioPrice = 75.20 * nights;
                    apartmentPrice = 68.70 * nights;
                    if (nights > 14)
                    {
                        studioPrice *= 0.8;
                    }
                    break;
                case "october":
                    studioPrice = 50 * nights;
                    apartmentPrice = 65 * nights;
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice *= 0.95;
                    }
                    else if (nights > 14)
                    {
                        studioPrice *= 0.7;
                    }
                    break;

            }

            if (nights>14)
            {
                apartmentPrice *= 0.9;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");

        }
    }
}
