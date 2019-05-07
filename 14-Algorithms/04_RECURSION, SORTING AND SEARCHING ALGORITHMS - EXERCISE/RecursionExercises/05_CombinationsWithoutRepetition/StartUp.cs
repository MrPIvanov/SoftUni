using System;

public class StartUp
{
    public static void Main()
    {
        var allNumbers = int.Parse(Console.ReadLine());
        var countNumbers = int.Parse(Console.ReadLine());

        var arr = new int[countNumbers];

        Generate(arr, 0 , allNumbers, 1);
    }

    private static void Generate(int[] arr, int index, int allNumbers, int element)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(" ", arr));
            return;
        }

        for (int i = element; i <= allNumbers; i++)
        {
            arr[index] = i;
            Generate(arr, index + 1, allNumbers, i + 1);
        }
    }
}