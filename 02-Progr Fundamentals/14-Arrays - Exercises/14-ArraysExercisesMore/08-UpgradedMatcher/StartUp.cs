namespace _08_UpgradedMatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<string> nameOfProducts = Console.ReadLine().Split().ToList();
            List<long> quantitiesOfProducs = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<decimal> priceOfProducts = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "done")
            {
                string product = command[0];
                long quantity = long.Parse(command[1]);

                int position = nameOfProducts.IndexOf(product);

                if (position>=quantitiesOfProducs.Count)
                {
                    Console.WriteLine($"We do not have enough {product}");
                }
                else
                {

                    if (quantitiesOfProducs[position]>=quantity)
                    {
                        Console.WriteLine($"{product} x {quantity} costs {priceOfProducts[position] * quantity:f2}");

                        quantitiesOfProducs[position] -= quantity;
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {product}");

                    }

                }

                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}