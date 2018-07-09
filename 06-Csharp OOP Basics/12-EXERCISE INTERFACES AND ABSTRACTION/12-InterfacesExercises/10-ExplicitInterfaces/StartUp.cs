using System;

class StartUp
{
    static void Main()
    {
        string citizenInfo;
        while ((citizenInfo = Console.ReadLine()) != "End")
        {
            var tokens = citizenInfo.Split();
            var name = tokens[0];
            var country = tokens[1];
            var age = int.Parse(tokens[2]);
            var currentCitizen = new Citizen(name,country,age);

            var currentIPerson = (IPerson)currentCitizen;
            var currentIResident = (IResident)currentCitizen;

            Console.WriteLine(currentIPerson.GetName());
            Console.WriteLine(currentIResident.GetName());
        }


    }
}