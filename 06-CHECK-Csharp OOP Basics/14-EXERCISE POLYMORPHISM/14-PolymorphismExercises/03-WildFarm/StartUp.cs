using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var allAnimals = new List<Animal>();

        string infoAnimal;
        while ((infoAnimal = Console.ReadLine()) != "End")
        {
            var animalArgs = infoAnimal.Split();
            var foodArgs = Console.ReadLine().Split();

            ParseInput(animalArgs, foodArgs, allAnimals);
        }

        PrintResults(allAnimals);

    }

    private static void PrintResults(List<Animal> allAnimals)
    {
        foreach (var animal in allAnimals)
        {
            Console.WriteLine($"{animal.GetType()}{animal}");
        }
    }

    private static void ParseInput(string[] animalArgs, string[] foodArgs, List<Animal> allAnimals)
    {
        var type = animalArgs[0];
        var name = animalArgs[1];
        var weight = double.Parse(animalArgs[2]);
        string livingRegion;
        string breed;
        double wingSize;

        switch (type)
        {
            case "Owl":
                wingSize = double.Parse(animalArgs[3]);
                Animal currentOwl = new Owl(name, weight, wingSize);

                currentOwl.TryToEat(currentOwl, foodArgs);
                allAnimals.Add(currentOwl);
                break;

            case "Hen":
                wingSize = double.Parse(animalArgs[3]);
                Animal currentHen = new Hen(name, weight, wingSize);

                currentHen.TryToEat(currentHen, foodArgs);
                allAnimals.Add(currentHen);
                break;

            case "Mouse":
                livingRegion = animalArgs[3];
                Animal currentMouse = new Mouse(name, weight, livingRegion);

                currentMouse.TryToEat(currentMouse, foodArgs);
                allAnimals.Add(currentMouse);
                break;

            case "Dog":
                livingRegion = animalArgs[3];
                Animal currentDog = new Dog(name, weight, livingRegion);

                currentDog.TryToEat(currentDog, foodArgs);
                allAnimals.Add(currentDog);
                break;

            case "Cat":
                livingRegion = animalArgs[3];
                breed = animalArgs[4];

                Animal currentCat = new Cat(name, weight, livingRegion, breed);

                currentCat.TryToEat(currentCat, foodArgs);
                allAnimals.Add(currentCat);
                break;


            case "Tiger":
                livingRegion = animalArgs[3];
                breed = animalArgs[4];

                Animal currentTiger = new Tiger(name, weight, livingRegion, breed);

                currentTiger.TryToEat(currentTiger, foodArgs);
                allAnimals.Add(currentTiger);
                break;
        }
    }
}