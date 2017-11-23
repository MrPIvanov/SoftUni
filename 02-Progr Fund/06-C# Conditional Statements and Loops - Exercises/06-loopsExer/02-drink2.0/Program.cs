using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_choosDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string prof = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 1.0;

            switch (prof)
            {
                case "Athlete":
                    price = 0.7;
                    Console.WriteLine($"The Athlete has to pay {(price*quantity):f2}.");
                    break;
                case "Businessman":
                    price =1.00;
                    Console.WriteLine($"The Businessman has to pay {(price * quantity):f2}.");
                    break;
                case "Businesswoman":
                    price = 1.00;
                    Console.WriteLine($"The Businesswoman has to pay {(price * quantity):f2}.");
                    break;
                case "SoftUni Student":
                    price = 1.70;
                    Console.WriteLine($"The SoftUni Student has to pay {(price * quantity):f2}.");
                    break;

                default:
                    price = 1.20;
                    Console.WriteLine($"The {prof} has to pay {(price * quantity):f2}.");
                    break;
            }


        }
    }
}
