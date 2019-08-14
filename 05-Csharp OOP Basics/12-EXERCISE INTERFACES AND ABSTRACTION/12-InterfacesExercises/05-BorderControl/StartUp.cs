using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        var allCitizens = new List<Citizen>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            if (tokens.Length==2)
            {
                var current = new Robot(tokens[0], tokens[1]);
                allCitizens.Add(current);
            }
            else
            {
                var current = new Human(tokens[0], tokens[2],int.Parse(tokens[1]));
                allCitizens.Add(current);
            }
        }
        var fakeId = Console.ReadLine();

        foreach (var citizen in allCitizens)
        {
            if (citizen.Id.EndsWith(fakeId))
            {
                Console.WriteLine(citizen.Id);
            }

        }
    }
}