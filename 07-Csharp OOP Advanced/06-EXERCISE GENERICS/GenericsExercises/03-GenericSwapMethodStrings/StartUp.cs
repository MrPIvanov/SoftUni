using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var allBoxes = new List<Box<string>>();
        var numberOfItems = int.Parse(Console.ReadLine());

        AddAllBoxes(allBoxes, numberOfItems);

        var indexTokens = Console.ReadLine().Split();
        var firstIndexs = int.Parse(indexTokens[0]);
        var secondIndex = int.Parse(indexTokens[1]);

        SwapBoxes(allBoxes, firstIndexs, secondIndex);

        PrintItems(allBoxes);
    }

    private static void SwapBoxes(List<Box<string>> allBoxes, int firstIndexs, int secondIndex)
    {
        var temBox = allBoxes[firstIndexs];
        allBoxes[firstIndexs] = allBoxes[secondIndex];
        allBoxes[secondIndex] = temBox;
    }

    private static void AddAllBoxes(List<Box<string>> allBoxes, int numberOfItems)
    {
        for (int i = 0; i < numberOfItems; i++)
        {
            var item = Console.ReadLine();
            var currentBox = new Box<string>(item);
            allBoxes.Add(currentBox);
        }
    }

    private static void PrintItems(List<Box<string>> allBoxes)
    {
        foreach (var box in allBoxes)
        {
            Console.WriteLine(box.ToString());
        }
    }
}