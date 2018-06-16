namespace _04_SupermData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allProducts = new Dictionary<string, Dictionary<decimal, int>>();

            string input;
            while ((input = Console.ReadLine()) != "stocked")
            {
                var inputArgs = input.Split();
                var name = inputArgs[0];
                var price = decimal.Parse(inputArgs[1]);
                var quantity = int.Parse(inputArgs[2]);

                if (!allProducts.ContainsKey(name))
                {
                    allProducts.Add(name, new Dictionary<decimal, int>());
                }

                allProducts[name].Add(price, quantity);
            }

            decimal totalSum = 0.0m;
            foreach (var product in allProducts)
            {
                
                Console.WriteLine($"{product.Key}: ${product.Value.Keys.Last():f2} * {product.Value.Values.Sum()} = " +
                    $"${product.Value.Keys.Last() * product.Value.Values.Sum():f2}");

                totalSum += product.Value.Keys.Last() * product.Value.Values.Sum();
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${totalSum:f2}");

        }
    }
}