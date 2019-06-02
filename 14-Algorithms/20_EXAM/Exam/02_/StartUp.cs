using System;
using System.Linq;

public class StartUp
{
    private static int StartingRow;
    private static int StartingCol;
    private static long counter;

    public static void Main()
    {
        counter = 0;

        var rows = int.Parse(Console.ReadLine());

        var matrix = new char[rows][];

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().ToCharArray();

            var index = matrix[i].Contains('3');
            if (index)
            {
                StartingRow = i;
                for (int y = 0; y < matrix[i].Length; y++)
                {
                    if (matrix[i][y] == '3')
                    {
                        StartingCol = y;
                    }
                }
            }
        }

        FindPath(StartingRow, StartingCol, matrix);
    }



    private static void FindPath(int startingRow, int startingCol, char[][] matrix)
    {
        if (startingRow < 0 || startingRow >= matrix.Length || startingCol < 0 || startingCol >= matrix[startingRow].Length)
        {
            return;
        }
       
        if (matrix[startingRow][startingCol] == '5')
        {
            Console.WriteLine(counter);
            Environment.Exit(0);
        }

        if (matrix[startingRow][startingCol] != '1')
        {
            if (IsCrossroad(startingRow, startingCol, matrix))
            {
                counter++;
            }

            matrix[startingRow][startingCol] = '1';

            FindPath(startingRow, startingCol + 1, matrix);
            FindPath(startingRow - 1, startingCol, matrix);
            FindPath(startingRow, startingCol - 1, matrix);
            FindPath(startingRow + 1, startingCol, matrix);

            matrix[startingRow][startingCol] = '0';
        }
       
    }

    private static bool IsCrossroad(int startingRow, int startingCol, char[][] matrix)
    {
        var temp = 0;

        if (startingRow > 0 && matrix[startingRow - 1][startingCol] == '0')
        {
            temp++;
        }
        if (startingRow < matrix.Length - 1 && matrix[startingRow + 1][startingCol] == '0')
        {
            temp++;
        }
        if (startingCol > 0 && matrix[startingRow][startingCol - 1] == '0')
        {
            temp++;
        }
        if (startingCol < matrix[startingRow].Length - 1 && matrix[startingRow][startingCol + 1] == '0')
        {
            temp++;
        }
        if (temp > 1)
        {
            return true;
        }
        return false;
    }
}