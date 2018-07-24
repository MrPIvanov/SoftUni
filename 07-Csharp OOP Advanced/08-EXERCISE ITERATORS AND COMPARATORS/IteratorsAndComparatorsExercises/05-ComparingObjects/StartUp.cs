using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var allPersons = new List<Person>();

        string personStr;
        while ((personStr = Console.ReadLine()) != "END")
        {
            var tokens = personStr.Split();
            var currentPerson = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);

            allPersons.Add(currentPerson);
        }

        var personToUse = allPersons[int.Parse(Console.ReadLine()) -1 ];

        var samePersonCounter = 0;

        foreach (var person in allPersons)
        {
            if (personToUse.CompareTo(person) == 0)
            {
                samePersonCounter++;
            }
        }

        if (samePersonCounter == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{samePersonCounter} {allPersons.Count - samePersonCounter} {allPersons.Count}");
        }
    }
}