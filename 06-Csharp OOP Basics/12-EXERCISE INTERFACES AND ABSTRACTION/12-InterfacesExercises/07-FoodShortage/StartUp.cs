using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var allPersons = new List<Person>();

        var numberOfPersons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPersons; i++)
        {
            var currentPersonTokens = Console.ReadLine().Split();

            if (currentPersonTokens.Length==3)
            {
                var name = currentPersonTokens[0];
                var age = int.Parse(currentPersonTokens[1]);
                var group = currentPersonTokens[2];

                var current = new Rebel(name,age,group);
                allPersons.Add(current);
            }
            else
            {
                var name = currentPersonTokens[0];
                var age = int.Parse(currentPersonTokens[1]);
                var id = currentPersonTokens[2];
                var birthdate = currentPersonTokens[3];

                var current = new Citizen(name,age,id,birthdate);
                allPersons.Add(current);
            }

        }

        string nameOfBuyer;
        while ((nameOfBuyer = Console.ReadLine()) != "End")
        {
            if (allPersons.FirstOrDefault(x => x.Name == nameOfBuyer) != null)
            {
                allPersons.FirstOrDefault(x => x.Name == nameOfBuyer).BuyFood();
            }
        }

        Console.WriteLine(allPersons.Sum(x=>x.FoodCount));
    }
}