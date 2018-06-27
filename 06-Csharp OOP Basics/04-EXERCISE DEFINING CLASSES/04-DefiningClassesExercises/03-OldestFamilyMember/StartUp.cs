using System;

class StartUp
{
    static void Main()
    {
        var numberOfPeopleToBeRead = int.Parse(Console.ReadLine());
        var family = new Family();

        for (int i = 0; i < numberOfPeopleToBeRead; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);

            var tempPerson = new Person(name, age);
            family.AddMember(tempPerson);

        }

        Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
    }
}