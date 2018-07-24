using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var allPersonsSortedSet = new SortedSet<Person>();
        var allPersonsHashSet = new HashSet<Person>();

        var numberOfPersons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPersons; i++)
        {
            var personArgs = Console.ReadLine().Split();

            var currentPerson = new Person(personArgs[0], int.Parse(personArgs[1]));
            allPersonsHashSet.Add(currentPerson);
            allPersonsSortedSet.Add(currentPerson);
        }

        Console.WriteLine(allPersonsSortedSet.Count);
        Console.WriteLine(allPersonsHashSet.Count);
    }
}