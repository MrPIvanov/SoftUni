using System;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var roomRows = int.Parse(Console.ReadLine());

        var samRow = 0;
        var samCol = 0;

        var room = new char[roomRows][];
        for (int i = 0; i < roomRows; i++)
        {
            var currentRow = Console.ReadLine().ToCharArray();
            room[i] = currentRow;

            if (currentRow.Contains('S'))
            {
                samRow = i;
                samCol = Array.IndexOf(currentRow, 'S');
            }
        }

        var directions = Console.ReadLine();

        while (true)
        {
            MoveEnemies(room);

            var samDead = CheckIfSamIsDead(room, ref samRow, ref samCol);

            if (samDead)
            {
                Console.WriteLine($"Sam died at {samRow}, {samCol}");
                break;
            }

            var nikoladzeDead = CheckIfNikoladzeIsDead(room, ref samRow, ref samCol);

            if (nikoladzeDead)
            {
                Console.WriteLine("Nikoladze killed!");
                break;
            }

            MoveSam(room, ref samRow, ref samCol, ref directions);

            nikoladzeDead = CheckIfNikoladzeIsDead(room, ref samRow, ref samCol);

            if (nikoladzeDead)
            {
                Console.WriteLine("Nikoladze killed!");
                break;
            }

        }

        PrintRoom(room);
    }

    private static void PrintRoom(char[][] room)
    {
        for (int i = 0; i < room.Length; i++)
        {
            Console.WriteLine(string.Join("", room[i]));
        }
    }

    private static bool CheckIfNikoladzeIsDead(char[][] room, ref int samRow, ref int samCol)
    {
        if (room[samRow].Contains('N'))
        {
            room[samRow][Array.IndexOf(room[samRow], 'N')] = 'X';
            return true;
        }

        return false;
    }

    private static void MoveSam(char[][] room, ref int samRow, ref int samCol, ref string directions)
    {
        room[samRow][samCol] = '.';

        switch (directions[0])
        {

            case 'U':
                samRow--;
                break;

            case 'D':
                samRow++;
                break;

            case 'L':
                samCol--;
                break;

            case 'R':
                samCol++;
                break;
        }

        room[samRow][samCol] = 'S';

        directions = directions.Remove(0,1);
    }

    private static bool CheckIfSamIsDead(char[][] room, ref int samRow, ref int samCol)
    {
        var roomRowWithSam = room[samRow];

        var indexSam = samCol;
        var indexD = Array.IndexOf(roomRowWithSam, 'd');
        var indexB = Array.IndexOf(roomRowWithSam, 'b');

        if (indexD != -1 && indexD > indexSam)
        {
            room[samRow][samCol] = 'X';
            return true;
        }

        if (indexB != -1 && indexB < indexSam)
        {
            room[samRow][samCol] = 'X';
            return true;
        }

        return false;
    }

    private static void MoveEnemies(char[][] room)
    {
        for (int i = 0; i < room.Length; i++)
        {
            var indexB = Array.IndexOf(room[i], 'b');
            var indexD = Array.IndexOf(room[i], 'd');

            if (indexB != -1)
            {
                if (indexB == room[i].Length - 1)
                {
                    room[i][indexB] = 'd';
                }
                else
                {
                    room[i][indexB] = '.';
                    room[i][indexB + 1] = 'b';
                }
            }

            if (indexD != -1)
            {
                if (indexD == 0)
                {
                    room[i][indexD] = 'b';
                }
                else
                {
                    room[i][indexD] = '.';
                    room[i][indexD - 1] = 'd';
                }
            }

        }
    }
}