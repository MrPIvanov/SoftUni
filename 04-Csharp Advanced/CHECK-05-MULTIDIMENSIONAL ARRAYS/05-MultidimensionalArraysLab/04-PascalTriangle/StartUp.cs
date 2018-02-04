namespace _04_PascalTriangle
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var rows = long.Parse(Console.ReadLine());

            long[][] result = MakeAndFill(rows);

            Print(result);
        }

        private static void Print(long[][] result)
        {
            for (long row = 0; row < result.GetLength(0); row++)
            {
                for (long col = 0; col < result[row].Length; col++)
                {
                    Console.Write($"{result[row][col]} ");
                }
                Console.WriteLine();
            }
        }



        private static long[][] MakeAndFill(long rows)
        {
            long[][] result = new long[rows][];
            var columns = rows;

            for (long row = 0; row < rows; row++)
            {
                result[row] = new long[row + 1];

                for (long col = 0; col < row+1; col++)
                {

                    if (col==0 || col == row)
                    {
                        result[row][col] = 1;

                    }
                    else
                    {
                        result[row][col] = result[row-1][col]+result[row-1][col-1];

                    }
                }

            }
            return result;
        }
    }
}