using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string input = Console.ReadLine();

        if (input == String.Empty)
        {
            return;
        }

        int[] arr = input
            .Split()
            .Select(int.Parse)
            .ToArray();

        Quick.Sort(arr);

        Console.WriteLine(String.Join(" ", arr));
    }
}