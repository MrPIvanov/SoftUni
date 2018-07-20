using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var allBoxes = new List<Box<string>>();
        var numberOfItems = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfItems; i++)
        {
            var item = Console.ReadLine();
            var currentBox = new Box<string>(item);
            allBoxes.Add(currentBox);
        }

        foreach (var box in allBoxes)
        {
            Console.WriteLine(box.ToString());
        }
    }
}