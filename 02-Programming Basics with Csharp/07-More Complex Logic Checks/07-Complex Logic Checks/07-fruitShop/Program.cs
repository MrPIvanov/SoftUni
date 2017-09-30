using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = -1.0;

            if (dayOfWeek=="saturday"||dayOfWeek=="sunday")
            {
                if (product=="banana")
                {
                    price = 2.7;
                }
                else if (product=="apple")
                {
                    price = 1.25;
                }
                else if (product=="orange")
                {
                    price = 0.9;
                }
                else if (product == "grapefruit")
                {
                    price = 1.6;
                }
                else if (product == "kiwi")
                {
                    price = 3.0;
                }
                else if (product == "pineapple")
                {
                    price = 5.6;
                }
                else if (product == "grapes")
                {
                    price = 4.2;
                }
            }

            else if (dayOfWeek=="monday"||
                dayOfWeek=="tuesday"||
                dayOfWeek=="wednesday"||
                dayOfWeek=="thursday"||
                dayOfWeek=="friday")
            {
                if (product == "banana")
                {
                    price = 2.5;
                }
                else if (product == "apple")
                {
                    price = 1.2;
                }
                else if (product == "orange")
                {
                    price = 0.85;
                }
                else if (product == "grapefruit")
                {
                    price = 1.45;
                }
                else if (product == "kiwi")
                {
                    price = 2.70;
                }
                else if (product == "pineapple")
                {
                    price = 5.5;
                }
                else if (product == "grapes")
                {
                    price = 3.85;
                }
            }

            if (price < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{price*quantity:f2}");
            }
        }
    }
}
