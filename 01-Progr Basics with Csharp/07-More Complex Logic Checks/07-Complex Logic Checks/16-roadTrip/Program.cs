using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_roadTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (season=="summer")
            {
                if (money<=100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {Math.Round(0.3*money, 2).ToString("00.00")}");
                }
                else if (money<=1000)
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {Math.Round(0.4 * money, 2).ToString("00.00")}");

                }
                else
                {
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {Math.Round(0.9 * money, 2).ToString("00.00")}");


                }




            }
            else if (season=="winter")
            {
                if (money <= 100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {Math.Round(0.7 * money, 2).ToString("00.00")}");
                }
                else if (money <= 1000)
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {Math.Round(0.8 * money, 2).ToString("00.00")}");

                }
                else
                {
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {Math.Round(0.9 * money, 2).ToString("00.00")}");


                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }



        }
    }
}
