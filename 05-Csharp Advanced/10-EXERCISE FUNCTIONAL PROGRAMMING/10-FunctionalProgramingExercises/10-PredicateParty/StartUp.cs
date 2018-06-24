namespace _10_PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var allPeople = Console.ReadLine().Split().ToList();

            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                var commandArgs = command.Split();

                switch (commandArgs[0])
                {
                    case "Remove":
                        switch (commandArgs[1])
                        {
                            case "StartsWith":
                                allPeople = allPeople.Where(x => !(x.StartsWith($"{commandArgs[2]}"))).ToList();
                                break;

                            case "Length":
                                allPeople = allPeople.Where(x => !(x.Length==int.Parse(commandArgs[2]))).ToList();
                                break;

                            case "EndsWith":
                                allPeople = allPeople.Where(x => !(x.EndsWith($"{commandArgs[2]}"))).ToList();
                                break;
                        }
                        
                        break;

                    case "Double":
                        switch (commandArgs[1])
                        {
                            case "StartsWith":
                                for (int i = 0; i < allPeople.Count; i++)
                                {
                                    if (allPeople[i].StartsWith($"{commandArgs[2]}"))
                                    {
                                        allPeople.Insert(i, allPeople[i]);
                                        i++;
                                    }
                                }
                                break;

                            case "Length":
                                for (int i = 0; i < allPeople.Count; i++)
                                {
                                    if (allPeople[i].Length==int.Parse(commandArgs[2]))
                                    {
                                        allPeople.Insert(i, allPeople[i]);
                                        i++;
                                    }
                                }
                                break;

                            case "EndsWith":
                                for (int i = 0; i < allPeople.Count; i++)
                                {
                                    if (allPeople[i].EndsWith($"{commandArgs[2]}"))
                                    {
                                        allPeople.Insert(i, allPeople[i]);
                                        i++;
                                    }
                                }
                                break;
                        }
                        break;
                }
            }


            if (allPeople.Count==0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", allPeople)} are going to the party!");
            }

        }
    }
}