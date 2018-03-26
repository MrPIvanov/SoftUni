using System;

public class StartUp
{
    static void Main()
    {
        var maxStarsOnRow = int.Parse(Console.ReadLine());

        for (int curentRow = 1; curentRow <= maxStarsOnRow; curentRow++)
        {
            PrintRow(curentRow,maxStarsOnRow);
        }

        for (int curentRow = maxStarsOnRow-1; curentRow >= 1; curentRow--)
        {
            PrintRow(curentRow, maxStarsOnRow);
        }
    }

    private static void PrintRow(int curentRow, int maxStarsOnRow)
    {
        for (int whiteSpace = 1; whiteSpace <= maxStarsOnRow-curentRow; whiteSpace++)
        {
            Console.Write(" ");
        }
        for (int numberOfStars = 1; numberOfStars <= curentRow; numberOfStars++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}