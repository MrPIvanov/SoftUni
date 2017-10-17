namespace _03_MinerTask
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, long>();
            string command = Console.ReadLine();
            int valueOfProduct = 0;

            while (command!="stop")
            {
                valueOfProduct = int.Parse(Console.ReadLine());

                if (result.ContainsKey(command))
                {
                    result[command] += valueOfProduct;
                }

                else
                {
                    result.Add(command, valueOfProduct);
                }



                command = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}