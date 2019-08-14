using System;
using System.Collections.Generic;

namespace _07_DistanceInLabyrinth
{
    public class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new string[n][];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().ToCharArray();
                matrix[i] = new string[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = line[j].ToString();
                }
            }

            var startRow = 0;
            var startCol = 0;
            var isFind = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == "*")
                    {
                        startRow = i;
                        startCol = j;
                        isFind = true;
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }
            }

            var visited = new bool[n, n];

            var queue = new Queue<Cell>();

            queue.Enqueue(new Cell(startRow, startCol, 0));

            while (queue.Count > 0)
            {
                var currentCell = queue.Dequeue();

                visited[currentCell.Row, currentCell.Col] = true;

                var row = currentCell.Row;
                var col = currentCell.Col;

                //up
                if (row - 1 >= 0 && matrix[row - 1][col] != "x" && visited[row -1,col] == false)
                {
                    queue.Enqueue(new Cell(row - 1, col, currentCell.Distance + 1));
                    matrix[row - 1][col] = (currentCell.Distance + 1).ToString();
                }

                //down
                if (row + 1 < n && matrix[row + 1][col] != "x" && visited[row + 1, col] == false)
                {
                    queue.Enqueue(new Cell(row + 1, col, currentCell.Distance + 1));
                    matrix[row + 1][col] = (currentCell.Distance + 1).ToString();
                }

                //right
                if (col + 1 < n && matrix[row][col + 1] != "x" && visited[row, col + 1] == false)
                {
                    queue.Enqueue(new Cell(row, col + 1, currentCell.Distance + 1));
                    matrix[row][col + 1] = (currentCell.Distance + 1).ToString();
                }

                //left
                if (col - 1 >= 0 && matrix[row][col - 1] != "x" && visited[row, col - 1] == false)
                {
                    queue.Enqueue(new Cell(row, col - 1, currentCell.Distance + 1));
                    matrix[row][col - 1] = (currentCell.Distance + 1).ToString();
                }
            }



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var item = matrix[i][j];

                    if (item == "0")
                    {
                        Console.Write("u");
                    }
                    else if (item == "*")
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(item);
                    }
                }
                Console.WriteLine();
            }

        }
    }

    public class Cell
    {
        public Cell(int row, int col, int distance)
        {
            this.Row = row;
            this.Col = col;
            this.Distance = distance;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public int Distance { get; set; }

    }

}