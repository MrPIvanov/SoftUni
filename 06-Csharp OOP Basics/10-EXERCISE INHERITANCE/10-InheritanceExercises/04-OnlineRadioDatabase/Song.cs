using System;
using System.Linq;

public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;

    public string ArtistName
    {
        get { return artistName; }
        set
        {
            if (value.Length<3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            artistName = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            songName = value;
        }
    }

    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value<0 || value>14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            minutes = value;
        }
    }

    public int Seconds
    {
        get { return seconds; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            seconds = value;
        }
    }

    public Song(string artistName, string songName, string timeString)
    {
        ArtistName = artistName;
        SongName = songName;

        var timeArgs = timeString.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        if (timeArgs.Length != 2)
        {
            throw new ArgumentException("Invalid song length.");
        }
        else
        {
            int mins = 0;
            int secs = 0;

            try
            {
                mins = int.Parse(timeArgs[0]);
                secs = int.Parse(timeArgs[1]);
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid song length.");
            }

            Minutes = mins;
            Seconds = secs;
        }
    }
}