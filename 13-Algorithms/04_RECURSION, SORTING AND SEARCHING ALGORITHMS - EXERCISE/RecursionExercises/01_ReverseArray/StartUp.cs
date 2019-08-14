using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var arr = Console.ReadLine().Split().ToArray();

        RotateArray(arr, 0);

        Console.WriteLine(string.Join(" ", arr));
    }

    private static void RotateArray(string[] arr, int index)
    {
        if (index >= arr.Length / 2)
        {
            return;
        }

        var temp = arr[index];
        arr[index] = arr[arr.Length - 1 - index];
        arr[arr.Length - 1 - index] = temp;

        RotateArray(arr, index + 1);
    }
}