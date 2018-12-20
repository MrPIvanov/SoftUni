using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var numberOfSongs = int.Parse(Console.ReadLine());
        var allSongs = new List<Song>();

        for (int i = 0; i < numberOfSongs; i++)
        {
            try
            {
                ParseSong(allSongs);
                Console.WriteLine("Song added.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        PrintResults(allSongs);
    }

    private static void PrintResults(List<Song> allSongs)
    {
        Console.WriteLine($"Songs added: {allSongs.Count}");

        long allSeconds = 0;
        foreach (var song in allSongs)
        {
            allSeconds += song.Seconds;
            allSeconds += song.Minutes * 60;
        }
        var hours = allSeconds / 3600;
        allSeconds = allSeconds % 3600;
        var mins = allSeconds / 60;
        allSeconds = allSeconds % 60;
        var secs = allSeconds;

        Console.WriteLine($"Playlist length: {hours}h {mins}m {secs}s");
    }

    private static void ParseSong(List<Song> allSongs)
    {
        var input = Console.ReadLine();
        var songArgs = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        if (songArgs.Length != 3)
        {
            throw new ArgumentException("Invalid song.");
        }
        else
        {
            var artistName = songArgs[0];
            var songName = songArgs[1];
            var timeString = songArgs[2];

            var currentSong = new Song(artistName, songName, timeString);

            allSongs.Add(currentSong);
        }
    }
}