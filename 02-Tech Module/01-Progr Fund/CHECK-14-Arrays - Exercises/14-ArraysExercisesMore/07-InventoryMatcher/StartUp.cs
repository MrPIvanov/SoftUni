namespace _07_InventoryMatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<string> nameOfProducts = Console.ReadLine().Split().ToList();
            long[] quantitiesOfProducs = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] priceOfProducts = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0]!="done")
            {
                int position = nameOfProducts.IndexOf(command[0]);

                Console.WriteLine($"{command[0]} costs: {priceOfProducts[position]}; Available quantity: {quantitiesOfProducs[position]}");


                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}