using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var borders = Console.ReadLine().Split();
        var rows = long.Parse(borders[0]);
        var cols = long.Parse(borders[1]);

        var evilNumbers = new HashSet<long>();
        var ivoSum = 0L;

        var inputIvo = Console.ReadLine();
        while (inputIvo != "Let the Force be with you")
        {
            var inputEvil = Console.ReadLine();

            var ivoArgs = inputIvo.Split().Select(long.Parse).ToArray();
            var evilArgs = inputEvil.Split().Select(long.Parse).ToArray();

            var ivoRow = ivoArgs[0];
            var ivoCol = ivoArgs[1];
            var evilRow = evilArgs[0];
            var evilCol = evilArgs[1];

            while (evilRow >= 0)
            {
                if (isInMatrix(evilRow, evilCol, rows, cols))
                {
                    evilNumbers.Add(evilRow * cols + evilCol);
                    evilRow--;
                    evilCol--;
                }
                else
                {
                    evilRow--;
                    evilCol--;
                }
            }

            while (ivoRow >= 0)
            {
                if (isInMatrix(ivoRow, ivoCol, rows, cols))
                {
                    var numberToAdd = ivoRow * cols + ivoCol;
                    if (!(evilNumbers.Contains(numberToAdd)))
                    {
                        ivoSum += numberToAdd;
                    }
                    ivoRow--;
                    ivoCol++;
                }
                else
                {
                    ivoRow--;
                    ivoCol++;
                }

            }

            inputIvo = Console.ReadLine();
        }

        Console.WriteLine(ivoSum);
    }

    private static bool isInMatrix(long row, long col, long rows, long cols)
    {
        if ((row >= 0 && row < rows) && (col >= 0 && col < cols))
        {
            return true;
        }
        return false;
    }


}