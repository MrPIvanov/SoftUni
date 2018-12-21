public class StartUp
{
    static void Main()
    {
        var progresInfoFile = new StreamProgressInfo(new File("name", 100, 10));
        var progresInfoMusic = new StreamProgressInfo(new Music("name", "album", 200, 10));

        var infoFile = progresInfoFile.CalculateCurrentPercent();
        var infoMusic = progresInfoMusic.CalculateCurrentPercent();
    }
}