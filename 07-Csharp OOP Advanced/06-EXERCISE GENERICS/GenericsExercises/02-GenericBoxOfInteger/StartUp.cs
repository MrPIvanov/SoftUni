using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var allBoxes = new List<Box<int>>();
        var numberOfItems = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfItems; i++)
        {
            var item = int.Parse(Console.ReadLine());
            var currentBox = new Box<int>(item);
            allBoxes.Add(currentBox);
        }

        foreach (var box in allBoxes)
        {
            Console.WriteLine(box.ToString());
        }
    }
}