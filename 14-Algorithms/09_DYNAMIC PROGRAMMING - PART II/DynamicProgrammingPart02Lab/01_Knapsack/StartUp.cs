using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int capacity = int.Parse(Console.ReadLine());

        string command;

        List<Item> itemsList = new List<Item>();
        while ((command = Console.ReadLine()) != "end")
        {
            var tokens = command.Split();

            itemsList.Add(new Item { Name = tokens[0], Weight = int.Parse(tokens[1]), Value = int.Parse(tokens[2]) });
        }

        Item[] items = itemsList.OrderBy(i => i.Name).ToArray();

        var result = FillKnapsack(items, capacity);

        Console.WriteLine($"Total Weight: {result.Sum(i => i.Weight)}");
        Console.WriteLine($"Total Value: {result.Sum(i => i.Value)}");
        Console.WriteLine(string.Join(Environment.NewLine, result.Select(i => i.Name)));
    }

    static List<Item> FillKnapsack(Item[] items, int capacity)
    {
        return null;
    }

    private class Item
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Value { get; set; }
    }
}