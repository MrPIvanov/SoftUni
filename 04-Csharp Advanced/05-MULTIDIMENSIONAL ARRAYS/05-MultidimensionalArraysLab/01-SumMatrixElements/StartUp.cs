namespace _01_SumMatrixElements
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var args = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var rows = args[0];
            var columns = args[1];
            int[,] matrix = new int[rows,columns];
            var result = 0;


            for (int row = 0; row < rows; row++)
            {
                int[] tempRow = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = tempRow[col];
                    result += tempRow[col];

                }


            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(result);

        }
    }
}