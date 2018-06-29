using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private List<Player> players;
    private int rating;

    public int Rating
    {
        get { return rating; }
        private set { rating = value; }
    }

    private List<Player> Players
    {
        get { return players; }
        set { players = value; }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }

    public Team(string[] tokens)
    {
        Name = tokens[1];
        Players = new List<Player>();
    }
    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }
    public void RemovePlayer(string playerName)
    {
        var playerToRemove = Players.FirstOrDefault(x => x.Name == playerName);
        if (playerToRemove == null)
        {
            System.Console.WriteLine($"Player {playerName} is not in {Name} team.");
        }
        else
        {
            Players.Remove(playerToRemove);
        }
    }
    public void CalculateRating()
    {
        if (Players.Count == 0)
        {
            Rating = 0;
        }
        else
        {
            var temp = 0;

            foreach (var player in Players)
            {
                temp += player.OverallStats;
            }

            Rating = temp / Players.Count;
        }
    }
}