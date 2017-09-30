using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string groupType = Console.ReadLine().ToLower();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = "";
            double priceForNight = 0.0;


            if (season=="winter")
            {
                if (groupType=="boys")
                {
                    priceForNight = 9.6;
                    sport = "Judo";
                }

                else if (groupType=="girls")
                {
                    priceForNight = 9.6;
                    sport = "Gymnastics";
                }
                else if (groupType=="mixed")
                {
                    priceForNight = 10.0;
                    sport = "Ski";
                }

            }
            else if (season=="spring")
            {
                if (groupType == "boys")
                {
                    priceForNight = 7.2;
                    sport = "Tennis";
                }

                else if (groupType == "girls")
                {
                    priceForNight = 7.2;
                    sport = "Athletics";
                }
                else if (groupType == "mixed")
                {
                    priceForNight = 9.5;
                    sport = "Cycling";
                }
            }
            else if (season=="summer")
            {
                if (groupType == "boys")
                {
                    priceForNight = 15;
                    sport = "Football";
                }

                else if (groupType == "girls")
                {
                    priceForNight = 15;
                    sport = "Volleyball";
                }
                else if (groupType == "mixed")
                {
                    priceForNight = 20;
                    sport = "Swimming";
                }
            }


            double discount = 1.0;





            if (students>=50)
            {
                discount = 0.5;
            }
            else if (students>=20)
            {
                discount = 0.85;
            }
            else if (students>=10)
            {
                discount = 0.95;
            }

            Console.WriteLine($"{sport} {(priceForNight*nights*discount*students):f2} lv.");

        }
    }
}
