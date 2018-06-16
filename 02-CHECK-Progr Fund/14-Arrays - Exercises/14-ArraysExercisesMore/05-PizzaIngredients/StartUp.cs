namespace _05_PizzaIngredients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<string> products = Console.ReadLine().Split().ToList();

            int lenghtOfProduct =int.Parse(Console.ReadLine());

            var useProducts = new List<string>();

            for (int i = 0; i < products.Count; i++)
            {
                if (useProducts.Count==10)
                {
                    break;

                }

                if (products[i].Length==lenghtOfProduct)
                {
                    useProducts.Add(products[i]);
                    Console.WriteLine($"Adding {products[i]}.");
                }

            }
            Console.WriteLine($"Made pizza with total of {useProducts.Count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", useProducts)}.");

        }
    }
}