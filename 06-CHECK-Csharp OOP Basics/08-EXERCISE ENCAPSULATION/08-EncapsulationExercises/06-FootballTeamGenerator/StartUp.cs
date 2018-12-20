using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var allTeams = new List<Team>();

        string input;
        while ((input=Console.ReadLine()) != "END")
        {
            var tokens = input.Split(";").ToArray();

            try
            {
                switch (tokens[0])
                {
                    case "Team":
                        var currentTeamToAdd = new Team(tokens);
                        allTeams.Add(currentTeamToAdd);
                        break;

                    case "Add":
                        if (allTeams.FirstOrDefault(x => x.Name == tokens[1]) == null)
                        {
                            throw new ArgumentException($"Team {tokens[1]} does not exist.");
                        }
                        else
                        {
                            var currentPlayerToAdd = new Player(tokens);
                            allTeams.FirstOrDefault(x => x.Name == tokens[1]).AddPlayer(currentPlayerToAdd);
                        }
                        break;

                    case "Remove":
                        var currentTeamToRemovePlayer = allTeams.FirstOrDefault(x => x.Name == tokens[1]);
                        if (currentTeamToRemovePlayer == null)
                        {
                            throw new ArgumentException($"Player {tokens[2]} is not in {tokens[1]} team.");
                        }
                        else
                        {
                            currentTeamToRemovePlayer.RemovePlayer(tokens[2]);
                        }

                        break;

                    case "Rating":
                        var teamToShow = allTeams.FirstOrDefault(x => x.Name == tokens[1]);

                        if (teamToShow == null)
                        {
                            throw new ArgumentException($"Team {tokens[1]} does not exist.");
                        }
                        else
                        {
                            teamToShow.CalculateRating();
                            Console.WriteLine($"{teamToShow.Name} - {teamToShow.Rating}");
                        }

                        break;
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}