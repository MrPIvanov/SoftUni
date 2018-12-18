using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var rows = int.Parse(Console.ReadLine());
        var matrix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        var coordinates = Console.ReadLine().Split();

        foreach (var cord in coordinates)
        {
            var tokens = cord.Split(",").Select(int.Parse).ToArray();

            var bombRow = tokens[0];
            var bombCol = tokens[1];

            var bombValue = matrix[bombRow][bombCol];

            if (bombValue > 0)
            {
                //top row

                if (bombRow - 1 >= 0 && bombCol - 1 >= 0 && matrix[bombRow - 1][bombCol - 1] > 0)
                {
                    matrix[bombRow - 1][bombCol - 1] -= bombValue;
                }

                if (bombRow -1 >= 0 && bombCol >= 0 && matrix[bombRow - 1][bombCol] > 0)
                {
                    matrix[bombRow - 1][bombCol] -= bombValue;
                }

                if (bombRow - 1 >= 0 && bombCol + 1 < matrix[0].Length && matrix[bombRow - 1][bombCol + 1] > 0)
                {
                    matrix[bombRow - 1][bombCol + 1] -= bombValue;
                }

                // second row

                if (bombRow >= 0 && bombCol - 1 >= 0 && matrix[bombRow][bombCol - 1] > 0)
                {
                    matrix[bombRow][bombCol - 1] -= bombValue;
                }

                if (bombRow >= 0 && bombCol >= 0 && matrix[bombRow][bombCol] > 0)
                {
                    matrix[bombRow][bombCol] -= bombValue;
                }

                if (bombRow >= 0 && bombCol + 1 < matrix[0].Length && matrix[bombRow][bombCol + 1] > 0)
                {
                    matrix[bombRow][bombCol + 1] -= bombValue;
                }

                // third row

                if (bombRow + 1 < matrix[0].Length && bombCol - 1 >= 0 && matrix[bombRow + 1][bombCol - 1] > 0)
                {
                    matrix[bombRow + 1][bombCol - 1] -= bombValue;
                }

                if (bombRow + 1 < matrix[0].Length && bombCol >= 0 && matrix[bombRow + 1][bombCol] > 0)
                {
                    matrix[bombRow + 1][bombCol] -= bombValue;
                }

                if (bombRow + 1 < matrix[0].Length && bombCol + 1 < matrix[0].Length && matrix[bombRow + 1][bombCol + 1] > 0)
                {
                    matrix[bombRow + 1][bombCol + 1] -= bombValue;
                }

            }

        }

        var activeSells = 0;
        var sum = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int y = 0; y < matrix[i].Length; y++)
            {
                if (matrix[i][y] > 0)
                {
                    activeSells++;
                    sum += matrix[i][y];
                }
            }
        }

        Console.WriteLine($"Alive cells: {activeSells}");
        Console.WriteLine($"Sum: {sum}");

        for (int i = 0; i < matrix.Length; i++)
        {
            Console.WriteLine(string.Join(" ", matrix[i]));
        }
    }
}