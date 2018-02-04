namespace _02_SquareWithMaximumSum
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var matrixParam = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var rows = matrixParam[0];
            var columns = matrixParam[1];
            int[,] matrix = new int[rows, columns];

            MatrixFill(rows, columns, matrix);

            BigestSquare(matrix);

        }

        private static void BigestSquare(int[,] matrix)
        {
            var tempBigestSum = int.MinValue;
            var tempRow = 0;
            var tempCol = 0;

            for (int row = 0; row <= matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1)-2; col++)
                {
                    if (tempBigestSum < matrix[row,col]+matrix[row, col+1]+matrix[row+1,col]+matrix[row+1,col+1])
                    {
                        tempBigestSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        tempRow = row;
                        tempCol = col;

                    }

                }
            }

            Console.WriteLine($"{matrix[tempRow,tempCol]} {matrix[tempRow, tempCol+1]}");
            Console.WriteLine($"{matrix[tempRow+1, tempCol]} {matrix[tempRow+1, tempCol + 1]}");
            Console.WriteLine(tempBigestSum);

        }

        private static void MatrixFill(int rows, int columns, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                var matrixRow = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = matrixRow[col];


                }
            }
        }
    }
}