using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StartUp
{
    public static void Main()
    {
        var allCards = new Dictionary<string, Dictionary<string, decimal>>();

        var input = Console.ReadLine();

        

        while (true)
        {

            if (input == "end")
            {
                break;
            }
            var inputArgs = input.Split();

            if (inputArgs[0] == "check")
            {
                if (allCards.ContainsKey(inputArgs[1]))
                {
                    Console.WriteLine($"{inputArgs[1]} is available!");
                }

                else
                {
                    Console.WriteLine($"{inputArgs[1]} is not available!");
                }
            }
            else
            {
                var tokens = input.Split(" - ").ToArray();

                var cardName = tokens[0];
                var sportName = tokens[1];
                var price = decimal.Parse(tokens[2]);

                if (allCards.ContainsKey(cardName))
                {
                    if (allCards[cardName].ContainsKey(sportName))
                    {
                        allCards[cardName][sportName] = price;
                    }
                    else
                    {
                        allCards[cardName].Add(sportName, price);
                    }

                }
                else
                {
                    allCards.Add(cardName, new Dictionary<string, decimal>());
                    allCards[cardName].Add(sportName, price);
                }
            }

          input = Console.ReadLine();
        }

        PrintCard(allCards);


    }

    private static void PrintCard(Dictionary<string, Dictionary<string, decimal>> allCards)
    {
        var sb = new StringBuilder();

        foreach (var cardName in allCards.OrderByDescending(x => x.Value.Count))
        {
            sb.AppendLine($"{cardName.Key}:");

            foreach (var sport in allCards[cardName.Key].OrderBy(x => x.Key))
            {
                sb.AppendLine($"  -{sport.Key} - {sport.Value:f2}");
            }
        }
       
        Console.WriteLine(sb.ToString().Trim());
    }
}