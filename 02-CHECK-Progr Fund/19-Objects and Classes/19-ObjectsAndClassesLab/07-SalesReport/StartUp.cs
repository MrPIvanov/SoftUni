using System;
using System.Collections.Generic;

namespace _07_SalesReport
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfSales = int.Parse(Console.ReadLine());

            var allSales = new List<Sale>();
            var endResult = new SortedDictionary<string, decimal>();

            for (int i = 0; i < numberOfSales; i++)
            {
                var tempSale = Console.ReadLine();

                allSales.Add(new Sale(tempSale));
            }

            foreach (var sale in allSales)
            {
                if (endResult.ContainsKey(sale.Town))
                {
                    endResult[sale.Town] += sale.Price * sale.Quantity;
                }
                else
                {
                    endResult[sale.Town] = 0.0m;
                    endResult[sale.Town] += sale.Price * sale.Quantity;
                }

            }

            foreach (var town in endResult)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }


        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public Sale(string line)
        {
            var lineArgs = line.Split();
            Town = lineArgs[0];
            Product = lineArgs[1];
            Price = decimal.Parse(lineArgs[2]);
            Quantity = decimal.Parse(lineArgs[3]);
        }
    }
}