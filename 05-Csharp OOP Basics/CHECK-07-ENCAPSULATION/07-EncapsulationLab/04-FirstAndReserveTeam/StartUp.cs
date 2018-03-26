using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var allPlayers = new Team("allPlayers");
        var allPersons = new List<Person>();
        var numberOfPeople = int.Parse(Console.ReadLine());

        for (int currentPerson = 0; currentPerson < numberOfPeople; currentPerson++)
        {
            var input = Console.ReadLine().Split();
            try
            {
                var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                allPersons.Add(person);
            }


            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }

        allPersons.ForEach(p => allPlayers.AddPlayer(p));

        Console.WriteLine($"First team has {allPlayers.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {allPlayers.ReserveTeam.Count} players.");

    }
}