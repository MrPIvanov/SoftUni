namespace _06_TargetPractice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var inputMatrix = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = inputMatrix[0];
            var columns = inputMatrix[1];
            var neededChars = rows * columns;

            var strToFill = Console.ReadLine();
            while (strToFill.Length <= neededChars)
            {
                strToFill += strToFill;
            }

            var inputShot = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var shotRow = inputShot[0];
            var shotColumn = inputShot[1];
            var shotRadius = inputShot[2];

            var matrix = new char[rows][];

            FillMatrix(matrix, rows, columns, strToFill);

            MakeShot(matrix, shotRow, shotColumn, shotRadius);

            FallingChars(matrix);

            PrintMatrix(matrix);

        }

        private static void PrintMatrix(char[][] matrix)
        {

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    Console.Write(matrix[row][column]);
                }

                Console.WriteLine();
            }
        }

        private static void FallingChars(char[][] matrix)
        {
            for (int column = 0; column < matrix[0].Length; column++)
            {
                var temp = new List<char>();
                for (int row = matrix.Length - 1; row >= 0; row--)
                {
                    if (matrix[row][column] == ' ')
                    {
                        continue;
                    }
                    temp.Add(matrix[row][column]);
                }
                var numberOfSpaceToAdd = matrix.Length - temp.Count;
                for (int i = 0; i < numberOfSpaceToAdd; i++)
                {
                    temp.Add(' ');
                }
                var index = 0;
                for (int row = matrix.Length - 1; row >= 0; row--)
                {
                    matrix[row][column] = temp[index];
                    index++;
                }

            }
        }

        private static void MakeShot(char[][] matrix, int shotRow, int shotColumn, int shotRadius)
        {
            if (shotRadius == 0)
            {
                matrix[shotRow][shotColumn] = ' ';
            }
            else
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int column = 0; column < matrix[row].Length; column++)
                    {
                        var indexDiffrence = Math.Abs(shotRow - row) + Math.Abs(shotColumn - column);

                        double distance = Math.Sqrt((row - shotRow)* (row - shotRow) + (column - shotColumn)*(column - shotColumn));
                        if (distance<=shotRadius)
                        {
                            matrix[row][column] = ' ';
                        }
                    }
                }
            }


        }

        private static void FillMatrix(char[][] matrix, int rows, int columns, string strToFill)
        {
            var text = strToFill.ToCharArray();
            var oddCounter = 0;
            var charCounter = 0;
            for (int row = rows - 1; row >= 0; row--)
            {
                matrix[row] = new char[columns];
                oddCounter++;
                if (oddCounter % 2 == 1)
                {
                    for (int column = columns - 1; column >= 0; column--)
                    {
                        matrix[row][column] = text[charCounter];
                        charCounter++;
                    }
                }
                else
                {
                    for (int column = 0; column < columns; column++)
                    {
                        matrix[row][column] = text[charCounter];
                        charCounter++;
                    }
                }
            }
        }
    }
}