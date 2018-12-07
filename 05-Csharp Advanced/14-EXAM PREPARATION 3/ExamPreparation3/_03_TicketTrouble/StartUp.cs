using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class StartUp
{
    static void Main()
    {
        var destination = Console.ReadLine();
        var text = Console.ReadLine();

        var FirstPattern = @"\[[^\]]*{([A-Z]{3} [A-Z]{2})}.*?{([A-Z]{1}[0-9]{1,2})}[^[]*\]";
        var SecondPattern = @"{[^}]*\[([A-Z]{3} [A-Z]{2})\].*?\[([A-Z]{1}[0-9]{1,2})\][^{]*}";

        var allTickets = new List<string>();

        var firstMatches = Regex.Matches(text, FirstPattern);
        var secondMatches = Regex.Matches(text, SecondPattern);

        foreach (Match match in firstMatches)
        {
            var currentDestination = match.Groups[1].Value.ToString();

            var currentSeatNumber = match.Groups[2].Value.ToString();

            if (currentDestination == destination)
            {
                allTickets.Add(currentSeatNumber);
            }
        }

        foreach (Match match in secondMatches)
        {
            var currentDestination = match.Groups[1].Value.ToString();

            var currentSeatNumber = match.Groups[2].Value.ToString();

            if (currentDestination == destination)
            {
                allTickets.Add(currentSeatNumber);
            }
        }

        var firstSeat = "";
        var secondSeat = "";

        if (allTickets.Count > 2)
        {
            for (int i = 0; i < allTickets.Count; i++)
            {
                for (int j = i + 1; j < allTickets.Count; j++)
                {
                    var currentNumber = int.Parse(allTickets[i].Remove(0, 1));

                    if (currentNumber == int.Parse(allTickets[j].Remove(0, 1)))
                    {
                        firstSeat = allTickets[i];
                        secondSeat = allTickets[j];
                    }
                }
            }
        }
        else
        {
            firstSeat = allTickets[0];
            secondSeat = allTickets[1];
        }
        
        Console.WriteLine($"You are traveling to {destination} on seats {firstSeat} and {secondSeat}.");

    }
}