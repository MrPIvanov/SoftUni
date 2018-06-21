namespace _08_RadioactiveMutantVampireBunnies
{
    using System;
    using System.Linq;

    class StartUp
    {
        public static bool playerStepOnBunny = false;
        public static bool playerWon = false;
        public static bool bunnyStepOnPlayer = false;
        public static int playerRow = 0;
        public static int playerCol = 0;
        

        static void Main()
        {
            var inputMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = inputMatrix[0];
            var cols = inputMatrix[1];
            var matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().ToArray();
            }

            var command = Console.ReadLine().ToArray();

            for (int i = 0; i < command.Length; i++)
            {

                var move = command[i];

                matrix = MovePlayer(matrix, move);

                matrix = MoveBunnys(matrix);

                if (playerWon)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;
                }
                if (playerStepOnBunny || bunnyStepOnPlayer)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    break;
                }
            }

        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static char[][] MoveBunnys(char[][] matrix)
        {
            var tempMatrix = new char[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                tempMatrix[i] = new char[matrix[i].Length];
                for (int y = 0; y < matrix[i].Length; y++)
                {
                    tempMatrix[i][y] = matrix[i][y];

                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    var temp = matrix[row][col];

                    if (temp == 'B')
                    {
                        if (tempMatrix[Math.Max(row - 1, 0)][col] == 'P')
                        {
                            bunnyStepOnPlayer = true;
                            playerRow = Math.Max(row - 1, 0);
                            playerCol = col;
                        }

                        if (tempMatrix[Math.Min(row + 1, matrix.Length - 1)][col] == 'P')
                        {
                            bunnyStepOnPlayer = true;
                            playerRow = Math.Min(row + 1, matrix.Length - 1);
                            playerCol = col;
                        }

                        if (tempMatrix[row][Math.Max(col - 1, 0)] == 'P')
                        {
                            bunnyStepOnPlayer = true;
                            playerRow = row;
                            playerCol = Math.Max(col - 1, 0);
                        }

                        if (tempMatrix[row][Math.Min(col + 1, matrix[row].Length - 1)] == 'P')
                        {
                            bunnyStepOnPlayer = true;
                            playerRow = row;
                            playerCol = Math.Min(col + 1, matrix[row].Length - 1);
                        }

                        tempMatrix[Math.Max(row - 1, 0)][col] = 'B';
                        tempMatrix[Math.Min(row + 1, matrix.Length - 1)][col] = 'B';
                        tempMatrix[row][Math.Max(col - 1, 0)] = 'B';
                        tempMatrix[row][Math.Min(col + 1, matrix[row].Length - 1)] = 'B';
                    }
                }

            }

            matrix = new char[tempMatrix.Length][];
            for (int i = 0; i < tempMatrix.Length; i++)
            {
                matrix[i] = new char[tempMatrix[i].Length];
                for (int y = 0; y < tempMatrix[i].Length; y++)
                {
                    matrix[i][y] = tempMatrix[i][y];
                }
            }

            return matrix;
        }

        private static char[][] MovePlayer(char[][] matrix, char move)
        {
            bool playerMoved = false;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'P')
                    {
                        playerMoved = true;

                        switch (move)
                        {
                            case 'L':
                                if (col - 1 == -1)
                                {
                                    playerWon = true;
                                    playerRow = row;
                                    playerCol = col;
                                    matrix[playerRow][playerCol] = '.';
                                }
                                else if (matrix[row][col - 1] == 'B')
                                {
                                    playerStepOnBunny = true;
                                    playerRow = row;
                                    playerCol = col -1;
                                    matrix[row][col] = '.';
                                }
                                else
                                {
                                    matrix[row][col] = '.';
                                    matrix[row][col - 1] = 'P';
                                }
                                break;

                            case 'R':
                                if (col + 1 == matrix[row].Length)
                                {
                                    playerWon = true;
                                    playerRow = row;
                                    playerCol = col;
                                    matrix[playerRow][playerCol] = '.';

                                }
                                else if (matrix[row][col + 1] == 'B')
                                {
                                    playerStepOnBunny = true;
                                    playerRow = row;
                                    playerCol = col +1;
                                    matrix[row][col] = '.';
                                }
                                else
                                {
                                    matrix[row][col] = '.';
                                    matrix[row][col + 1] = 'P';
                                }
                                break;

                            case 'U':
                                if (row - 1 == -1)
                                {
                                    playerWon = true;
                                    playerRow = row;
                                    playerCol = col;
                                    matrix[playerRow][playerCol] = '.';

                                }
                                else if (matrix[row - 1][col] == 'B')
                                {
                                    playerStepOnBunny = true;
                                    playerRow = row -1;
                                    playerCol = col;
                                    matrix[row][col] = '.';
                                }
                                else
                                {
                                    matrix[row][col] = '.';
                                    matrix[row - 1][col] = 'P';
                                }
                                break;

                            case 'D':
                                if (row + 1 == matrix.Length)
                                {
                                    playerWon = true;
                                    playerRow = row;
                                    playerCol = col;
                                    matrix[playerRow][playerCol] = '.';

                                }
                                else if (matrix[row + 1][col] == 'B')
                                {
                                    playerStepOnBunny = true;
                                    playerRow = row+1;
                                    playerCol = col;
                                    matrix[row][col] = '.';
                                }
                                else
                                {
                                    matrix[row][col] = '.';
                                    matrix[row + 1][col] = 'P';
                                }
                                break;
                        }
                    }

                    if (playerMoved)
                    {
                        break;
                    }
                }
                if (playerMoved)
                {
                    break;
                }
            }

            return matrix;
        }
    }
}