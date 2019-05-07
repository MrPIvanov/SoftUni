using System;

public class StartUp
{
    public static void Main()
    {
        var set = int.Parse(Console.ReadLine());
        var numbers = int.Parse(Console.ReadLine());

        var arr = new int[numbers];

        GenerateResults(arr, 0, set, 1);
    }

    private static void GenerateResults(int[] arr, int indexToFill, int set, int element)
    {
        if (indexToFill == arr.Length)
        {
            Console.WriteLine(string.Join(" ", arr));
            return;
        }

        for (int i = element; i <= set; i++)
        {
            arr[indexToFill] = i;
            GenerateResults(arr, indexToFill + 1, set, i);
        }
    }
}