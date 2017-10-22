namespace _06_Heists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            long[] prices = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long jewelPrice = prices[0];
            long goldPrice = prices[1];
            long totalEarn = 0;
            long totalSpent = 0;
            long jewelFind = 0;
            long goldFind = 0;

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0]!="Jail" && command[1]!="Time")
            {
                totalSpent += long.Parse(command[1]);

                char[] loot = command[0].ToCharArray();

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i]=='%')
                    {
                        jewelFind++;
                    }
                    else if (loot[i] == '$')
                    {
                        goldFind++;
                    }
                }

                command = Console.ReadLine().Split().ToArray();
            }

            totalEarn = jewelFind * jewelPrice + goldFind * goldPrice;

            if (totalEarn>=totalSpent)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarn-totalSpent}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalSpent-totalEarn}.");
            }
        }
    }
}