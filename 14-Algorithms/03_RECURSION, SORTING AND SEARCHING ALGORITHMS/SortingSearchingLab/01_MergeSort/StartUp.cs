using System;
using System.Linq;

public class Program
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

        Mergesort<int>.Sort(arr);

        Console.WriteLine(String.Join(" ", arr));
    }
}