using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var allPeople = new Dictionary<string, SortedDictionary<string, string>>();

        var targetIndex = int.Parse(Console.ReadLine());

        string input;
        while ((input = Console.ReadLine()) != "end transmissions")
        {
            var tokens = input.Split("=");
            var personName = tokens[0];
            var personInfo = tokens[1].Split(";").ToArray();

            if (!allPeople.ContainsKey(personName))
            {
                allPeople[personName] = new SortedDictionary<string, string>();
            }

            foreach (var info in personInfo)
            {
                var args = info.Split(":");
                var infoKey = args[0];
                var infoValue = args[1];

                allPeople[personName][infoKey] = infoValue;
            }
        }

        var nameToShow = Console.ReadLine().Remove(0,5);

        var collectedIndex = 0;

        Console.WriteLine($"Info on {nameToShow}:");
        foreach (var info in allPeople[nameToShow])
        {
            Console.WriteLine($"---{info.Key}: {info.Value}");

            collectedIndex += info.Key.Length;
            collectedIndex += info.Value.Length;
        }

        Console.WriteLine($"Info index: {collectedIndex}");

        if (collectedIndex >= targetIndex)
        {
            Console.WriteLine("Proceed");
        }

        else
        {
            Console.WriteLine($"Need {targetIndex - collectedIndex} more info.");
        }
    }
}