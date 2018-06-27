using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var allDoctors = new Dictionary<string, List<string>>();
        var departments = new Dictionary<string, List<List<string>>>();

        string command = Console.ReadLine();
        while (command != "Output")
        {
            var tokens = command.Split();
            var departament = tokens[0];
            var firstName = tokens[1];
            var lastName = tokens[2];
            var pacient = tokens[3];
            var fullName = firstName + lastName;

            if (!allDoctors.ContainsKey(firstName + lastName))
            {
                allDoctors[fullName] = new List<string>();
            }
            if (!departments.ContainsKey(departament))
            {
                departments[departament] = new List<List<string>>();
                for (int room = 0; room < 20; room++)
                {
                    departments[departament].Add(new List<string>());
                }
            }

            bool freeRoom = departments[departament].SelectMany(x => x).Count() < 60;
            if (freeRoom)
            {
                int room = 0;
                allDoctors[fullName].Add(pacient);
                for (int i = 0; i < departments[departament].Count; i++)
                {
                    if (departments[departament][i].Count < 3)
                    {
                        room = i;
                        break;
                    }
                }
                departments[departament][room].Add(pacient);
            }

            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "End")
        {
            string[] args = command.Split();

            if (args.Length == 1)
            {
                Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            }
            else if (args.Length == 2 && int.TryParse(args[1], out int room))
            {
                Console.WriteLine(string.Join("\n", departments[args[0]][room - 1].OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine(string.Join("\n", allDoctors[args[0] + args[1]].OrderBy(x => x)));
            }
            command = Console.ReadLine();
        }
    }
}