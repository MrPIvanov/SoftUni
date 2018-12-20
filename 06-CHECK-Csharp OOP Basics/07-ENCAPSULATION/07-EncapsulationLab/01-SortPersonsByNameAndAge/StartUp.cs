using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var allPersons = new List<Person>();
        var numberOfPeople = int.Parse(Console.ReadLine());

        for (int currentPerson = 0; currentPerson < numberOfPeople; currentPerson++)
        {
            var input = Console.ReadLine().Split();
            var person = new Person(input[0],input[1],int.Parse(input[2]));
            allPersons.Add(person);
        }
        allPersons.OrderBy(p => p.FirstName)
            .ThenBy(a => a.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p));

    }
}