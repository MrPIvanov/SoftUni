using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        long bagCapacity = long.Parse(Console.ReadLine());
        string[] safeItems = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var bag = new Dictionary<string, Dictionary<string, long>>();
        long gold = 0;
        long gems = 0;
        long money = 0;

        for (int i = 0; i < safeItems.Length; i += 2)
        {
            string itemName = safeItems[i];
            long itemQuantity = long.Parse(safeItems[i + 1]);

            string itemType = string.Empty;

            if (itemName.Length == 3)
            {
                itemType = "Cash";
            }
            else if (itemName.ToLower().EndsWith("gem"))
            {
                itemType = "Gem";
            }
            else if (itemName.ToLower() == "gold")
            {
                itemType = "Gold";
            }

            if (itemType == "")
            {
                continue;
            }
            else if (bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + itemQuantity)
            {
                continue;
            }

            switch (itemType)
            {
                case "Gem":
                    if (!bag.ContainsKey(itemType))
                    {
                        if (bag.ContainsKey("Gold"))
                        {
                            if (itemQuantity > bag["Gold"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[itemType].Values.Sum() + itemQuantity > bag["Gold"].Values.Sum())
                    {
                        continue;
                    }
                    break;
                case "Cash":
                    if (!bag.ContainsKey(itemType))
                    {
                        if (bag.ContainsKey("Gem"))
                        {
                            if (itemQuantity > bag["Gem"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[itemType].Values.Sum() + itemQuantity > bag["Gem"].Values.Sum())
                    {
                        continue;
                    }
                    break;
            }

            if (!bag.ContainsKey(itemType))
            {
                bag[itemType] = new Dictionary<string, long>();
            }

            if (!bag[itemType].ContainsKey(itemName))
            {
                bag[itemType][itemName] = 0;
            }

            bag[itemType][itemName] += itemQuantity;
            if (itemType == "Gold")
            {
                gold += itemQuantity;
            }
            else if (itemType == "Gem")
            {
                gems += itemQuantity;
            }
            else if (itemType == "Cash")
            {
                money += itemQuantity;
            }
        }

        foreach (var item in bag)
        {
            Console.WriteLine($"<{item.Key}> ${item.Value.Values.Sum()}");
            foreach (var item2 in item.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
            {
                Console.WriteLine($"##{item2.Key} - {item2.Value}");
            }
        }
    }
}
