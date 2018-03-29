using System;
using System.Collections.Generic;
using System.Linq;

namespace ETH_Dips_Buy
{
    class StartUp
    {
        const decimal PRICE_MULTIPLIER = 1.23m;
        const int MAX_ETH_PRICE = 10_000;
        const int DIFFRENCE_TO_SHOW_FROM_CURRENT_PRICE = 200;

        public static int Diffrence { get; set; }
        public static decimal CurrentEUR { get; set; }
        public static List<decimal> BuyOrders { get; set; } = new List<decimal>();
        public static List<decimal> SellOrders { get; set; } = new List<decimal>();

        static void Main()
        {
            CurrentEUR = 0.0m;
            Console.Write("Enter the diffrent between buy orders: ");
            Diffrence = int.Parse(Console.ReadLine());

            Console.Write("Enter the starting ETH price: ");
            decimal oldPrice = decimal.Parse(Console.ReadLine());

            for (int i = Diffrence; i <= MAX_ETH_PRICE; i+= Diffrence)
            {
                BuyOrders.Add(i);
                SellOrders.Add(i*PRICE_MULTIPLIER);
            }

            SellOrders = SellOrders.Where(o => o > oldPrice).ToList();
            decimal limitForBuyOrders = SellOrders.First();
            limitForBuyOrders /= PRICE_MULTIPLIER;
            BuyOrders = BuyOrders.Where(o => o < limitForBuyOrders).ToList();

            Console.Write("Enter Current ETH Price: ");
            string currentInput;
            while ((currentInput = Console.ReadLine()) != "end")
            {

                decimal newPrice = decimal.Parse(currentInput);

                if (newPrice>oldPrice)
                {
                    PriceIncrease(newPrice);
                }
                else
                {
                    PriceDecrease(newPrice);
                }

                oldPrice = newPrice;

                PrintResults(oldPrice);
            }
        }

        private static void PrintResults(decimal oldPrice)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {CurrentEUR:f0} EUR");

            Console.WriteLine();
            Console.Write($"Current BUY Orders:  ");
            foreach (var order in BuyOrders.OrderByDescending(x => x).Where(o => o > oldPrice - DIFFRENCE_TO_SHOW_FROM_CURRENT_PRICE))
            {
                Console.Write($"{order:f0},  ");
            }

            Console.WriteLine();
            Console.Write($"Current SELL Orders:  ");
            foreach (var order in SellOrders.OrderBy(x => x).Where(o => o < oldPrice + DIFFRENCE_TO_SHOW_FROM_CURRENT_PRICE))
            {
                Console.Write($"{order:f2},  ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter Current ETH Price: ");
        }

        private static void PriceIncrease(decimal newPrice)
        {
            int numberOfSellOrdersFilled = SellOrders.Where(o => o <= newPrice).ToList().Count();
            for (int i = 0; i < numberOfSellOrdersFilled; i++)
            {
                decimal numberToAdd = BuyOrders.Last() + Diffrence;
                BuyOrders.Add(numberToAdd);
                CurrentEUR -= numberToAdd;
            }

            decimal amountSold = SellOrders.Where(o => o <= newPrice).ToList().Sum();
            CurrentEUR += amountSold;

            SellOrders = SellOrders.Where(o => o > newPrice).ToList();
        }

        private static void PriceDecrease(decimal newPrice)
        {
            int numberOfBuyOrdersFilled = BuyOrders.Where(o => o >= newPrice).ToList().Count();

            for (int i = 0; i < numberOfBuyOrdersFilled; i++)
            {
                decimal numberToAdd = BuyOrders.Last() * PRICE_MULTIPLIER;
                SellOrders.Add(numberToAdd);
                SellOrders = SellOrders.OrderBy(x=>x).ToList();
                BuyOrders.RemoveAt(BuyOrders.Count - 1);

            }
        }
    }
}
