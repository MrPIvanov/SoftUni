using System;

public class StartUp
{
    public static void Main()
    {
        var totalLoops = int.Parse(Console.ReadLine());

        var arr = new int[totalLoops];

        Generate(arr, totalLoops, 0);
    }

    private static void Generate(int[] arr, int totalLoops, int currentLoop)
    {
        if (currentLoop == totalLoops)
        {
            Console.WriteLine(string.Join(" ", arr));
            return;
        }

        for (int counter = 1; counter <= totalLoops; counter++)
        {
            arr[currentLoop] = counter;
            Generate(arr, totalLoops, currentLoop + 1);
        }
    }

}