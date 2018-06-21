namespace _05_Rubik_sMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var matrixInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = matrixInput[0];
            var columns = matrixInput[1];
            var totalCount = rows * columns;

            var matrix = new int[rows][];
            var counter = 1;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[columns];
                for (int column = 0; column < columns; column++)
                {
                    matrix[row][column] = counter;
                    counter++;
                }
            }
            var numberOfCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommand; i++)
            {
                var commandArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var direction = commandArgs[1];

                switch (direction)
                {
                    case "left":
                        var rowLeft = int.Parse(commandArgs[0]);
                        var movesLeft = int.Parse(commandArgs[2]);
                        MoveLeft(rowLeft, movesLeft, matrix, columns);
                        break;

                    case "right":
                        var rowRight = int.Parse(commandArgs[0]);
                        var movesRight = int.Parse(commandArgs[2]);
                        MoveRight(rowRight, movesRight, matrix, columns);
                        break;

                    case "up":
                        var columnUp = int.Parse(commandArgs[0]);
                        var movesUp = int.Parse(commandArgs[2]);
                        MoveUp(columnUp, movesUp, matrix, rows);
                        break;

                    case "down":
                        var columnDown = int.Parse(commandArgs[0]);
                        var movesDown = int.Parse(commandArgs[2]);
                        MoveDown(columnDown, movesDown, matrix, rows);
                        break;
                }

            }

            counter = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (matrix[row][column] == counter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int rowSearch = 0; rowSearch < rows; rowSearch++)
                        {
                            bool findSwap = false;
                            for (int columnSearch = 0; columnSearch < columns; columnSearch++)
                            {
                                if (matrix[rowSearch][columnSearch] == counter)
                                {
                                    Console.WriteLine($"Swap ({row}, {column}) with ({rowSearch}, {columnSearch})");
                                    var tempNumber = matrix[row][column];
                                    matrix[row][column] = matrix[rowSearch][columnSearch];
                                    matrix[rowSearch][columnSearch] = tempNumber;
                                    findSwap = true;
                                    break;
                                }

                            }
                            if (findSwap)
                            {
                                break;
                            }

                        }
                    }
                    counter++;
                }

            }

        }

        private static void MoveRight(int rowRight, int movesRight, int[][] matrix, int columns)
        {
            var temp = new List<int>(matrix[rowRight]);
            movesRight = movesRight % columns;
            for (int i = 0; i < movesRight; i++)
            {
                var tempNumber = temp.Last();
                temp.RemoveAt(temp.Count-1);
                temp.Insert(0,tempNumber);
            }

            for (int i = 0; i < columns; i++)
            {
                matrix[rowRight][i] = temp[i];
            }
        }

        private static void MoveLeft(int rowLeft, int movesLeft, int[][] matrix, int columns)
        {
            var temp = new List<int>(matrix[rowLeft]);
            movesLeft = movesLeft % columns;
            for (int i = 0; i < movesLeft; i++)
            {
                var tempNumber = temp.First();
                temp.RemoveAt(0);
                temp.Add(tempNumber);
            }

            for (int i = 0; i < columns; i++)
            {
                matrix[rowLeft][i]= temp[i];
            }
        }

        private static void MoveUp(int columnUp, int movesUp, int[][] matrix, int rows)
        {
            var temp = new List<int>();
            movesUp = movesUp % rows;

            for (int i = 0; i < rows; i++)
            {
                temp.Add(matrix[i][columnUp]);
            }
            for (int i = 0; i < movesUp; i++)
            {
                var tempNumber = temp.First();
                temp.RemoveAt(0);
                temp.Add(tempNumber);
            }
            for (int i = 0; i < rows; i++)
            {
                matrix[i][columnUp] = temp[i];
            }
        }

        private static void MoveDown(int columnDown, int movesDown, int[][] matrix, int rows)
        {
            var temp = new List<int>();
            movesDown = movesDown % rows;

            for (int i = 0; i < rows; i++)
            {
                temp.Add(matrix[i][columnDown]);
            }
            for (int i = 0; i < movesDown; i++)
            {
                var tempNumber = temp.Last();
                temp.RemoveAt(temp.Count-1);
                temp.Insert(0,tempNumber);
            }
            for (int i = 0; i < rows; i++)
            {
                matrix[i][columnDown] = temp[i];
            }
        }
    }
}