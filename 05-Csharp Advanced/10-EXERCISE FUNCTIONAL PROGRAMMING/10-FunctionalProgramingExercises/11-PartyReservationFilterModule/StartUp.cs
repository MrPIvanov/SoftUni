namespace _11_PartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var allNames = Console.ReadLine().Split().ToList();
            var allFilters = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                var commandArgs = command.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commandArgs[0])
                {
                    case "Add filter":
                        allFilters.Add($"{commandArgs[1]} {commandArgs[2]}");
                    break;

                    case "Remove filter":
                        allFilters.Remove($"{commandArgs[1]} {commandArgs[2]}");
                        break;

                }
            }

            foreach (var filter in allFilters)
            {
                var filterArgs = filter.Split();
                switch (filterArgs[0])
                {
                    case "Starts":
                        allNames = allNames.Where(x => !(x.StartsWith($"{filterArgs[2]}"))).ToList();
                        break;

                    case "Ends":
                        allNames = allNames.Where(x => !(x.EndsWith($"{filterArgs[2]}"))).ToList();
                        break;

                    case "Length":
                        allNames = allNames.Where(x => x.Length != int.Parse(filterArgs[1])).ToList();
                        break;

                    case "Contains":
                        allNames = allNames.Where(x => !(x.Contains($"{filterArgs[1]}"))).ToList();
                        break;
                }
            }

            Console.WriteLine(String.Join(" ",allNames));
        }
    }
}