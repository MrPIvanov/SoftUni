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
            var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
            allPersons.Add(person);
        }
        var percentage = decimal.Parse(Console.ReadLine());

        allPersons.ForEach(p => p.IncreaseSalary(percentage));
        allPersons.ForEach(p => Console.WriteLine(p));
    }
}