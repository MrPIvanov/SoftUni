using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var firstNumber = input[0];
        var secondNumber = input[1];

        var queue = new Queue<Item>();
        queue.Enqueue(new Item(firstNumber, null));

        Item lastItem = null;

        if (firstNumber <= secondNumber)
        {
            while (true)
            {
                var currentItem = queue.Dequeue();

                if (currentItem.Value == secondNumber)
                {
                    lastItem = currentItem;
                    break;
                }
                else
                {
                    if (currentItem.Value + 1 <= secondNumber)
                    {
                        queue.Enqueue(new Item(currentItem.Value + 1, currentItem));
                    }
                    if (currentItem.Value + 2 <= secondNumber)
                    {
                        queue.Enqueue(new Item(currentItem.Value + 2, currentItem));
                    }
                    if (currentItem.Value * 2 <= secondNumber)
                    {
                        queue.Enqueue(new Item(currentItem.Value * 2, currentItem));
                    }
                }

            }
        }

        var collectionToPrint = new List<int>();

        while (lastItem != null)
        {
            collectionToPrint.Add(lastItem.Value);
            lastItem = lastItem.PrevItem;
        }

        collectionToPrint.Reverse();

        Console.WriteLine(string.Join(" -> ", collectionToPrint));
    }

    private class Item
    {
        public int Value { get; set; }

        public Item PrevItem { get; set; }

        public Item(int value, Item prevItem)
        {
            this.Value = value;
            this.PrevItem = prevItem;
        }
    }
}