using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            if (age<0||age>122)
            {
                Console.WriteLine("Error!");
            }

            else if (age<=18)
            {
                ticketPrice = 12;
                if (day=="weekend")
                {
                    ticketPrice = 15;
                }
                else if (day=="holiday")
                {
                    ticketPrice = 5;
                }
                Console.WriteLine($"{ticketPrice}$");

            }
            else if (age <= 64)
            {
                ticketPrice = 18;
                if (day == "weekend")
                {
                    ticketPrice = 20;
                }
                else if (day == "holiday")
                {
                    ticketPrice = 12;
                }
                Console.WriteLine($"{ticketPrice}$");

            }
            else if (age <= 122)
            {
                ticketPrice = 12;
                if (day == "weekend")
                {
                    ticketPrice = 15;
                }
                else if (day == "holiday")
                {
                    ticketPrice = 10;
                }
                Console.WriteLine($"{ticketPrice}$");

            }

        }
    }
}
