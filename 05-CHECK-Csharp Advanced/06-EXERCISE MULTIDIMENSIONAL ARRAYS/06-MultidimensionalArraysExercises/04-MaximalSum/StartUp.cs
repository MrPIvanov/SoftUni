namespace _04_MaximalSum
{
    using System;
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
            var matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSum = int.MinValue;
            var currentMaxSum = 0;
            var currentStart = new int[2];
            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int column = 0; column < matrix[row].Length - 2; column++)
                {
                    currentMaxSum = matrix[row][column] +
                        matrix[row][column + 1] +
                        matrix[row][column + 2] +
                        matrix[row + 1][column] +
                        matrix[row + 1][column + 1] +
                        matrix[row + 1][column + 2] +
                        matrix[row + 2][column] +
                        matrix[row + 2][column + 1] +
                        matrix[row + 2][column + 2];

                    if (currentMaxSum>maxSum)
                    {
                        maxSum = currentMaxSum;
                        currentStart = new int[]{ row , column};
                    }

                }

            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[currentStart[0]][currentStart[1]]} {matrix[currentStart[0]][currentStart[1]+1]} {matrix[currentStart[0]][currentStart[1]+2]}");
            Console.WriteLine($"{matrix[currentStart[0] +1][currentStart[1]]} {matrix[currentStart[0]+1][currentStart[1] + 1]} {matrix[currentStart[0]+1][currentStart[1] + 2]}");
            Console.WriteLine($"{matrix[currentStart[0] +2][currentStart[1]]} {matrix[currentStart[0]+2][currentStart[1] + 1]} {matrix[currentStart[0]+2][currentStart[1] + 2]}");


        }
    }
}