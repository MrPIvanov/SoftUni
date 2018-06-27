using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var allCats = new List<Cat>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var args = input.Split();
            Cat currentCat = null;
            switch (args[0])
            {
                case "StreetExtraordinaire":
                    currentCat = new StreetExtraordinaire(args[1], double.Parse(args[2]));
                    break;

                case "Siamese":
                    currentCat = new Siamese(args[1], double.Parse(args[2]));
                    break;

                case "Cymric":
                    currentCat = new Cymric(args[1], double.Parse(args[2]));
                    break;
            }

            allCats.Add(currentCat);
        }

        var catToPrint = Console.ReadLine();
        Console.WriteLine(allCats.Where(x=>x.Name==catToPrint).FirstOrDefault());
    }
}