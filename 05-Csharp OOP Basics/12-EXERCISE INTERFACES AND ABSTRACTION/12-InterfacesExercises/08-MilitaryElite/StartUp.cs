using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var allSoldiers = new List<Soldier>();

        string line;
        while ((line = Console.ReadLine()) != "End")
        {
            var args = line.Split();
            var id = args[1];
            var firstName = args[2];
            var lastName = args[3];
            decimal salary;
            string corps;
            int codeNumber;
            

            switch (args[0])
            {
                case "Private":
                    salary = decimal.Parse(args[4]);
                    var currentPrivate = new Private(firstName, lastName, id, salary);
                    allSoldiers.Add(currentPrivate);
                    break;

                case "LeutenantGeneral":
                    salary = decimal.Parse(args[4]);
                    var currentLeutenantGeneral = new LeutenantGeneral(firstName, lastName,id,salary);

                    for (int i = 5; i < args.Length; i++)
                    {
                        Private currentPrivateToAdd = (Private)allSoldiers.FirstOrDefault(x => x.Id == args[i]);
                        currentLeutenantGeneral.AddPrivate(currentPrivateToAdd);
                    }
                    allSoldiers.Add(currentLeutenantGeneral);
                    break;

                case "Engineer":
                    salary = decimal.Parse(args[4]);
                    corps = args[5];
                    if (corps == "Airforces" || corps == "Marines")
                    {
                        var currentEngineer = new Engineer(firstName, lastName, id, salary, corps);
                        for (int i = 6; i < args.Length; i++)
                        {
                            var name = args[i];
                            i++;
                            var hoursWorked = int.Parse(args[i]);

                            var currentRepair = new Repair(name, hoursWorked);
                            currentEngineer.AddRepair(currentRepair);
                        }
                        allSoldiers.Add(currentEngineer);
                    }                   
                    break;

                case "Commando":
                    salary = decimal.Parse(args[4]);
                    corps = args[5];
                    if (corps == "Airforces" || corps == "Marines")
                    {
                        var currentCommando = new Commando(firstName, lastName, id, salary, corps);
                        for (int i = 6; i < args.Length; i++)
                        {
                            var name = args[i];
                            i++;
                            var state = args[i];
                            if (state == "inProgress" || state == "Finished")
                            {
                                var currentMission = new Mission(name, state);
                                currentCommando.AddMission(currentMission);
                            }
                        }
                        allSoldiers.Add(currentCommando);

                    }
                    break;

                case "Spy":
                    codeNumber = int.Parse(args[4]);
                    var currentSpy = new Spy(firstName, lastName, id, codeNumber);
                    allSoldiers.Add(currentSpy);
                    break;
            }
            
        }

        PrintResults(allSoldiers);
    }

    private static void PrintResults(List<Soldier> allSoldiers)
    {
        foreach (var soldier in allSoldiers)
        {
            Console.WriteLine(soldier);
        }
    }
}