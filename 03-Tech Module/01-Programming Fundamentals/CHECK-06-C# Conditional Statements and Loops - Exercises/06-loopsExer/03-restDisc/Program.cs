using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_restDisc
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string package = Console.ReadLine().ToLower();
            string hall = "";
            double priceHall = 1.0;
            double pricePack = 1.0;
            double discount = 1.0;

            if (size<=50)
            {
                hall = "Small Hall";
                priceHall = 2500;
            }
            else if (size<=100)
            {
                hall = "Terrace";
                priceHall = 5000;
            }
            else if (size <= 120)
            {
                hall = "Great Hall";
                priceHall = 7500;
            }

            if (package=="normal")
            {
                pricePack =500;
                discount = 0.95;
            }
            else if (package=="gold")
            {
                pricePack =750;
                discount = 0.9;
            }
            else if (package == "platinum")
            {
                pricePack = 1000;
                discount = 0.85;
            }

            double allPrice = ((priceHall + pricePack) * discount) / size;

            if (size<=120)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {allPrice:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }




        }
    }
}
