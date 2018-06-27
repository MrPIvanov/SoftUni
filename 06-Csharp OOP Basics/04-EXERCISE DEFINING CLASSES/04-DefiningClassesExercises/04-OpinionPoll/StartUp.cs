using System;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var allPersons = new Family();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var tempPerson = new Person(input[0], int.Parse(input[1]));
            allPersons.AddPerson(tempPerson);
        }

        var result = allPersons.AllPeople.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

        foreach (var person in result)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}