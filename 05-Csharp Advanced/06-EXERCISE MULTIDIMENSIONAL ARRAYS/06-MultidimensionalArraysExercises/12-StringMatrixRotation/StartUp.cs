namespace _12_StringMatrixRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var command = Console.ReadLine().Split('(', ')');
            var degreese = int.Parse(command[1])%360;

            var collection = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                collection.Add(input);
            }

            var longestLine = collection.OrderByDescending(x => x.Length).First().Length;

            var matrix = new char[collection.Count][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[longestLine];
                for (int col = 0; col < longestLine; col++)
                {
                    if (collection[row].Length>col)
                    {
                        matrix[row][col] = collection[row][col];
                    }
                    else
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }

            switch (degreese)
            {
                case 0:
                    foreach (var row in matrix)
                    {
                        foreach (var col in row)
                        {
                            Console.Write(col);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 90:
                    for (int col = 0; col < longestLine; col++)
                    {
                        for (int row = matrix.Length-1; row >=0; row--)
                        {
                            Console.Write(matrix[row][col]);
                        }
                        Console.WriteLine();
                    }

                    break;

                case 180:
                    for (int row = matrix.Length-1; row >=0; row--)
                    {
                        for (int col = matrix[row].Length-1; col>=0; col--)
                        {
                            Console.Write(matrix[row][col]);
                        }
                        Console.WriteLine();
                    }

                    break;

                case 270:
                    for (int col = longestLine-1; col>=0; col--)
                    {
                        for (int row = 0; row < matrix.Length; row++)
                        {
                            Console.Write(matrix[row][col]);

                        }
                        Console.WriteLine();
                    }
                    
                    break;
            }
        }
    }
}