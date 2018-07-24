using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {



        var allPersonsByName = new SortedSet<Person>(new PersonComparerByName());
        var allPersonsByAge = new SortedSet<Person>(new PersonComparerByAge());

        var numberOfPersons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPersons; i++)
        {
            var personArgs = Console.ReadLine().Split();

            var currentPerson = new Person(personArgs[0], int.Parse(personArgs[1]));
            allPersonsByAge.Add(currentPerson);
            allPersonsByName.Add(currentPerson);
        }

        foreach (var person in allPersonsByName)
        {
            Console.WriteLine(person);
        }

        foreach (var person in allPersonsByAge)
        {
            Console.WriteLine(person);
        }
    }
}