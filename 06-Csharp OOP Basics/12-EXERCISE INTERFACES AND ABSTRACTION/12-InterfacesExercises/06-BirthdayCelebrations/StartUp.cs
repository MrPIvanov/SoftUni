using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        var allLiveCreatures = new List<LiveCreature>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            if (tokens[0] == "Citizen")
            {
                var name = tokens[1];
                var age = int.Parse(tokens[2]);
                var id = tokens[3];
                var birthdate = tokens[4];

                var current = new Human(name,birthdate,age,id);
                allLiveCreatures.Add(current);
            }
            else if (tokens[0] == "Pet")
            {
                var name = tokens[1];
                var birthdate = tokens[2];

                var current = new Pet(name,birthdate);
                allLiveCreatures.Add(current);
            }
        }
        var birthdateYear = Console.ReadLine();

        foreach (var liveCreature in allLiveCreatures)
        {
            if (liveCreature.Birthdate.EndsWith(birthdateYear))
            {
                Console.WriteLine(liveCreature.Birthdate);
            }

        }


    }
}