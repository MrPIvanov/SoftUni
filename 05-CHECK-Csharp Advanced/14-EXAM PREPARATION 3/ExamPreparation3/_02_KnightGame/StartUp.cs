using System;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var rows = int.Parse(Console.ReadLine());
        var board = new char[rows][];

        for (int i = 0; i < rows; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }

        var rowToRemove = 0;
        var colToRemove = 0;
        var maxHits = 0;
        var bools = new bool[8];
        var removedCount = 0;
        bool boardClean = false;

        while (!boardClean)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (board[row][col] == 'K')
                    {
                        bools[0] = row - 2 >= 0 && col - 1 >= 0 && board[row - 2][col - 1] == 'K';
                        bools[1] = row - 2 >= 0 && col + 1 < rows && board[row - 2][col + 1] == 'K';
                        bools[2] = row - 1 >= 0 && col - 2 >= 0 && board[row - 1][col - 2] == 'K';
                        bools[3] = row - 1 >= 0 && col + 2 < rows && board[row - 1][col + 2] == 'K';
                        bools[4] = row + 1 < rows && col - 2 >= 0 && board[row + 1][col - 2] == 'K';
                        bools[5] = row + 1 < rows && col + 2 < rows && board[row + 1][col + 2] == 'K';
                        bools[6] = row + 2 < rows && col - 1 >= 0 && board[row + 2][col - 1] == 'K';
                        bools[7] = row + 2 < rows && col + 1 < rows && board[row + 2][col + 1] == 'K';

                        var currentHits = bools.Where(x => x == true).Count();

                        if (currentHits > maxHits)
                        {
                            boardClean = false;
                            rowToRemove = row;
                            colToRemove = col;
                            maxHits = currentHits;
                        }
                    }
                }
            }
            if (maxHits == 0)
            {
                boardClean = true;
            }

            if (!boardClean)
            {
                board[rowToRemove][colToRemove] = 'O';
                maxHits = 0;
                removedCount++;
            }
        }
        Console.WriteLine(removedCount);
    }
}