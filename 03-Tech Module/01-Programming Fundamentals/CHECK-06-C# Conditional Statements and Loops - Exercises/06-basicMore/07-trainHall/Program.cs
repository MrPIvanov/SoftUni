using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_trainHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItemsToBye = int.Parse(Console.ReadLine());

            double moneySpent = 0;

            for (int i = 1; i <= numberOfItemsToBye; i++)
            {
                string currentItemName = Console.ReadLine();
                double currentItemPrice = double.Parse(Console.ReadLine());
                double currentItemCount = double.Parse(Console.ReadLine());

                if (currentItemCount>1)
                {
                    currentItemName += "s";
                }

                Console.WriteLine($"Adding {currentItemCount} {currentItemName} to cart.");

                moneySpent = moneySpent + (currentItemCount*currentItemPrice);


            }

            Console.WriteLine($"Subtotal: ${moneySpent:f2}");

            if (moneySpent>budget)
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(moneySpent-budget):f2} more.");
            }

            else
            {
                Console.WriteLine($"Money left: ${budget-moneySpent:f2}");
            }

        }
    }
}
