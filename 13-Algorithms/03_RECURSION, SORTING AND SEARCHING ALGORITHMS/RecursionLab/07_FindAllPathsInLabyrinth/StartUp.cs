using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var rows = int.Parse(Console.ReadLine());
        var cols = int.Parse(Console.ReadLine());

        var labirint = new char[rows][];

        for (int i = 0; i < rows; i++)
        {
            labirint[i] = Console.ReadLine().ToCharArray();
        }

        var resultList = new List<char>();

        FindPath(labirint, 0, 0, 'S', resultList);

    }

    private static void FindPath(char[][] labirint, int row, int col, char direction, List<char> resultList)
    {
        resultList.Add(direction);

        if (row < 0 || row >= labirint.Length)
        {
            resultList.RemoveAt(resultList.Count - 1);
            return;
        }

        if (col < 0 || col >= labirint[0].Length)
        {
            resultList.RemoveAt(resultList.Count - 1);
            return;
        }

        if (labirint[row][col] == '*')
        {
            resultList.RemoveAt(resultList.Count - 1);
            return;
        }

        if (labirint[row][col] == 'M')
        {
            resultList.RemoveAt(resultList.Count - 1);
            return;
        }

        if (labirint[row][col] == 'e')
        {
            Console.WriteLine(string.Join("", resultList.Skip(1)));
            resultList.RemoveAt(resultList.Count - 1);
            return;
        }


        MarkPossition(labirint, row, col);

        FindPath(labirint, row - 1, col, 'U', resultList);
        FindPath(labirint, row + 1, col, 'D', resultList);
        FindPath(labirint, row, col + 1, 'R', resultList);
        FindPath(labirint, row, col - 1, 'L', resultList);

        UnMarkPossition(labirint, row, col);

        resultList.RemoveAt(resultList.Count - 1);
    }

    private static void UnMarkPossition(char[][] labirint, int row, int col)
    {
        labirint[row][col] = '-';
    }

    private static void MarkPossition(char[][] labirint, int row, int col)
    {
        labirint[row][col] = 'M';
    }
}