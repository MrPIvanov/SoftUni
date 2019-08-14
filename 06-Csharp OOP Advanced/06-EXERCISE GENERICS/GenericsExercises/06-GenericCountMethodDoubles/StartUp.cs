using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var allBoxes = new List<Box<double>>();
        var numberOfItems = int.Parse(Console.ReadLine());

        AddAllBoxes(allBoxes, numberOfItems);

        var element = double.Parse(Console.ReadLine());

        int numberOfGreaterElements = GetGreaterElements(allBoxes, element);

        Console.WriteLine(numberOfGreaterElements);
    }

    private static int GetGreaterElements(List<Box<double>> allBoxes, double element)
    {
        var result = 0;

        foreach (var box in allBoxes)
        {
            if (box.Item.CompareTo(element) == 1)
            {
                result++;
            }
        }

        return result;
    }

    private static void AddAllBoxes(List<Box<double>> allBoxes, int numberOfItems)
    {
        for (int i = 0; i < numberOfItems; i++)
        {
            var item = double.Parse(Console.ReadLine());
            var currentBox = new Box<double>(item);
            allBoxes.Add(currentBox);
        }
    }
}