using System;

public class StartUp
{
    private static int[] parties;

    public static void Main()
    {
        var targetSum = int.Parse(Console.ReadLine());
        var numberOfParties = int.Parse(Console.ReadLine());

        parties = new int[numberOfParties];

        for (int i = 0; i < numberOfParties; i++)
        {
            parties[i] = int.Parse(Console.ReadLine());
        }

        var resultCounter = 0;

        Generate(0, 0);

        Console.WriteLine(resultCounter);
    }

    private static void Generate(int indexToFill, int elementToTake)
    {
        if (indexToFill >= parties.Length)
        {
            return;
        }

        for (int i = indexToFill; i < parties.Length; i++)
        {
            if (true)
            {

            }
        }
    }
}