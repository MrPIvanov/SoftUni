using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var allPeople = new List<PersonInfo>();

        string input;
        while ((input=Console.ReadLine()) != "End")
        {
            var args = input.Split();
            var name = args[0];
            PersonInfo currentPerson;

            if (allPeople.Any(x => x.Name == name))
            {
                currentPerson = allPeople.Where(x => x.Name == name).FirstOrDefault();
            }
            else
            {
                currentPerson = new PersonInfo(name);
                allPeople.Add(currentPerson);
            }

            switch (args[1])
            {
                case "company":
                    currentPerson.Company = new Company(args[2],args[3],decimal.Parse(args[4]));
                    break;

                case "pokemon":
                    currentPerson.Pokemons.Add(new Pokemon(args[2],args[3]));
                    break;

                case "parents":
                    currentPerson.Parents.Add(new Parent(args[2], args[3]));
                    break;

                case "children":
                    currentPerson.Childrens.Add(new Children(args[2], args[3]));
                    break;

                case "car":
                    currentPerson.Car = new Car(args[2], args[3]);
                    break;
            }
        }

        var nameToPrint = Console.ReadLine();
        var personToPrint = allPeople.Where(x=>x.Name == nameToPrint).FirstOrDefault();
        Console.WriteLine(personToPrint.ToString());


    }
}