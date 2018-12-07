using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var movies = new Dictionary<string, long>();

        var genre = Console.ReadLine();
        var duration = Console.ReadLine();
        var totalSeconds = (long)0;

        var input = "";
        while ((input = Console.ReadLine()) != "POPCORN!")
        {
            var tokens = input.Split("|");

            var args = tokens[2].Split(":");
            var hours = int.Parse(args[0]);
            var mins = int.Parse(args[1]);
            var secs = int.Parse(args[2]);

            var movieTime = new TimeSpan(hours, mins, secs);

            var movieName = tokens[0];
            var movieDuration = (long)movieTime.TotalSeconds;

            totalSeconds += movieDuration;

            if (tokens[1] == genre)
            {
                movies.Add(movieName, movieDuration);
            }

        }

        if (duration == "Short")
        {
            movies = movies.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
        }
        else
        {
            movies = movies.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
        }

        var moviesShown = 0;
        var wifeChoise = "";
        while ((wifeChoise = Console.ReadLine()) != "Yes")
        {
            var currentMovie = movies.ElementAt(moviesShown);
            Console.WriteLine(currentMovie.Key.ToString());
            moviesShown++;
        }

        var currentMovieToPrint = movies.ElementAt(moviesShown);
        Console.WriteLine(currentMovieToPrint.Key);

        var time = new TimeSpan(currentMovieToPrint.Value * 10000000);
        Console.WriteLine($"We're watching {currentMovieToPrint.Key} - {time.Hours:d2}:{time.Minutes:d2}:{time.Seconds:d2}");

        var totalTime = new TimeSpan(totalSeconds * 10000000);
        Console.WriteLine($"Total Playlist Duration: {totalTime.Hours:d2}:{totalTime.Minutes:d2}:{totalTime.Seconds:d2}");
    }
}