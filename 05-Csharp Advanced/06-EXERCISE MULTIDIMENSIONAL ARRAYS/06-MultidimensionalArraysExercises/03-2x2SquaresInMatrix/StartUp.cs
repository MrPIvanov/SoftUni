namespace _03_2x2SquaresInMatrix
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

            var matrix = new string[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            var result = 0;
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int column = 0; column < matrix[row].Length - 1; column++)
                {
                    if (matrix[row][column] == matrix[row + 1][column] &&
                        matrix[row][column] == matrix[row][column + 1] &&
                        matrix[row][column] == matrix[row + 1][column + 1])
                    {
                        result++;
                    }

                }

            }

            Console.WriteLine(result);

        }
    }
}
