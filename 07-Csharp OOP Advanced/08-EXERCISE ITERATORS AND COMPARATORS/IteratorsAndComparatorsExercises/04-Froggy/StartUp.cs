using System;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        var lake = new Lake(stones);

        Console.WriteLine(string.Join(", ", lake));

        
    }
}