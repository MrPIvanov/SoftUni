using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_gameTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            double people = double.Parse(Console.ReadLine());
            double moneyLeft = 0.00;
            double moneyNeed = 0.00;

            if (people<=4)
            {
                moneyLeft = 0.25 * money;
                if (category=="vip")
                {
                    moneyNeed = 499.99 * people;
                }
                else if (category=="normal")
                {
                    moneyNeed = 249.99 * people;
                }
                
            }
            else if (people <= 9)
            {
                moneyLeft = 0.4 * money;
                if (category == "vip")
                {
                    moneyNeed = 499.99 * people;
                }
                else if (category == "normal")
                {
                    moneyNeed = 249.99 * people;
                }

            }
            else if (people <= 24)
            {
                moneyLeft = 0.5 * money;
                if (category == "vip")
                {
                    moneyNeed = 499.99 * people;
                }
                else if (category == "normal")
                {
                    moneyNeed = 249.99 * people;
                }

            }
            else if (people <= 49)
            {
                moneyLeft = 0.6 * money;
                if (category == "vip")
                {
                    moneyNeed = 499.99 * people;
                }
                else if (category == "normal")
                {
                    moneyNeed = 249.99 * people;
                }

            }
            else if (people >= 50)
            {
                moneyLeft = 0.75 * money;
                if (category == "vip")
                {
                    moneyNeed = 499.99 * people;
                }
                else if (category == "normal")
                {
                    moneyNeed = 249.99 * people;
                }

            }

            if (moneyLeft>moneyNeed)
            {
                Console.WriteLine($"Yes! You have {moneyLeft-moneyNeed:f2} leva left.");
            }

            else if (moneyLeft<moneyNeed)
            {
                Console.WriteLine($"Not enough money! You need {moneyNeed-moneyLeft:f2} leva.");
            }
        }
    }
}
