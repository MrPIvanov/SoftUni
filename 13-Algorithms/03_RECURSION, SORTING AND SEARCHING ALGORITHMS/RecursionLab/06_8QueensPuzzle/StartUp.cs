using System;
using System.Collections.Generic;

public class StartUp
{
    const int Size = 8;
    static bool[,] chessboard = new bool[Size, Size];
    static int solutionsFound = 0;

    static HashSet<int> attackedRows = new HashSet<int>();
    static HashSet<int> attackedCols = new HashSet<int>();
    static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
    static HashSet<int> attackedRightDiagonals = new HashSet<int>();

    public static void Main()
    {
        PlaceQueen(0);
    }

    private static void PlaceQueen(int row)
    {
        if (row == Size)
        {
            PrintSolution();
            return;
        }

        for (int col = 0; col < Size; col++)
        {
            if (CanPlaceQueen(row, col))
            {
                MarkPossitions(row, col);
                PlaceQueen(row + 1);
                UnMarkPossitions(row, col);
            }
        }

    }

    private static void MarkPossitions(int row, int col)
    {
        attackedRows.Add(row);
        attackedCols.Add(col);
        attackedLeftDiagonals.Add(col - row);
        attackedRightDiagonals.Add(col + row);
        chessboard[row, col] = true;
    }

    private static void UnMarkPossitions(int row, int col)
    {
        attackedRows.Remove(row);
        attackedCols.Remove(col);
        attackedLeftDiagonals.Remove(col - row);
        attackedRightDiagonals.Remove(col + row);
        chessboard[row, col] = false;
    }

    private static bool CanPlaceQueen(int row, int col)
    {
        if (!attackedCols.Contains(col) &&
            !attackedRows.Contains(row) &&
            !attackedLeftDiagonals.Contains(col - row) &&
            !attackedRightDiagonals.Contains(col + row))
        {
            return true;
        }
        return false;
    }

    private static void PrintSolution()
    {
        for (int row = 0; row < Size; row++)
        {
            for (int col = 0; col < Size; col++)
            {
                if (chessboard[row,col])
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("- ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        solutionsFound++;
    }
}