using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var allPeople = new List<Person>();
        var mainPerson = Console.ReadLine();
        var allConnections = new List<string>();


        string line;
        while ((line = Console.ReadLine()) != "End")
        {
            var args = line.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (args.Length==2)
            {
                allConnections.Add(line);
            }

            else
            {
                var tempArgs = args[0].Split();
                var name = tempArgs[0] + " " + tempArgs[1];
                var birthDay = tempArgs[2];
                var currentPerson = new Person(name, birthDay);
                allPeople.Add(currentPerson);   //Maybe Check if already exist ?
            }
        }

        foreach (var inputLine in allConnections)
        {
            var args = inputLine.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (ChechForDate(args[0]))
            {
                if (ChechForDate(args[1]))
                {
                    //date - date
                    allPeople.Where(x => x.BirthDay == args[0]).FirstOrDefault().Childrens
                        .Add(allPeople.Where(x => x.BirthDay == args[1]).FirstOrDefault());

                    allPeople.Where(x => x.BirthDay == args[1]).FirstOrDefault().Parents
                        .Add(allPeople.Where(x => x.BirthDay == args[0]).FirstOrDefault());
                }
                else
                {
                    //date - name
                    allPeople.Where(x => x.BirthDay == args[0]).FirstOrDefault().Childrens
                           .Add(allPeople.Where(x => x.Name == args[1]).FirstOrDefault());

                    allPeople.Where(x => x.Name == args[1]).FirstOrDefault().Parents
                        .Add(allPeople.Where(x => x.BirthDay == args[0]).FirstOrDefault());
                }

            }
            else
            {
                if (ChechForDate(args[1]))
                {
                    //name - date
                    allPeople.Where(x => x.Name == args[0]).FirstOrDefault().Childrens
                           .Add(allPeople.Where(x => x.BirthDay == args[1]).FirstOrDefault());

                    allPeople.Where(x => x.BirthDay == args[1]).FirstOrDefault().Parents
                        .Add(allPeople.Where(x => x.Name == args[0]).FirstOrDefault());
                }
                else
                {
                    //name - name
                    allPeople.Where(x => x.Name == args[0]).FirstOrDefault().Childrens
                           .Add(allPeople.Where(x => x.Name == args[1]).FirstOrDefault());

                    allPeople.Where(x => x.Name == args[1]).FirstOrDefault().Parents
                        .Add(allPeople.Where(x => x.Name == args[0]).FirstOrDefault());
                }
            }
        }

        PrintResults(mainPerson, allPeople);
    }

    private static void PrintResults(string mainPerson, List<Person> allPeople)
    {
        Person result = null;

        if (ChechForDate(mainPerson))
        {
            result = allPeople.Where(x => x.BirthDay == mainPerson).FirstOrDefault();
        }
        else
        {
            result = allPeople.Where(x => x.Name == mainPerson).FirstOrDefault();
        }
        Console.WriteLine($"{result.Name} {result.BirthDay}");
        Console.WriteLine($"Parents:");
        foreach (var parent in result.Parents)
        {
            Console.WriteLine($"{parent.Name} {parent.BirthDay}");
        }
        Console.WriteLine($"Children:");
        foreach (var child in result.Childrens)
        {
            Console.WriteLine($"{child.Name} {child.BirthDay}");
        }
    }

    private static bool ChechForDate(string input)
    {
        if (char.IsNumber(input[0]))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}