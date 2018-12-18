namespace _11_ParkingSystem
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var matrixInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = matrixInput[0];
            var cols = matrixInput[1];
            var matrix = new char[rows][];

            string carInput;
            while ((carInput = Console.ReadLine()) != "stop")
            {
                var carInputArgs = carInput.Split().Select(int.Parse).ToArray();
                var entryRow = carInputArgs[0];
                var targetRow = carInputArgs[1];
                var targetCol = carInputArgs[2];
                var parkingNotFull = true;
                var breakTheLoop = false;

                var freeRow = 0;
                var freeCol = 0;

                if (matrix[targetRow] == null)
                {
                    matrix[targetRow] = new char[cols];
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[targetRow][col] = ' ';
                    }

                }

                while (true)
                {
                    if (matrix[targetRow][targetCol] == ' ')
                    {
                        freeRow = targetRow;
                        freeCol = targetCol;
                        break;
                    }
                    else
                    {
                        var oddCOunter = 1;
                        var counter = 0;
                        while (true)
                        {
                            if (oddCOunter % 2 == 1)
                            {
                                counter++;
                                if (matrix[targetRow][Math.Max(targetCol - counter, 1)] == ' ')
                                {
                                    freeRow = targetRow;
                                    freeCol = Math.Max(targetCol - counter, 1);
                                    breakTheLoop = true;
                                    break;
                                }
                            }
                            else
                            {
                                if (matrix[targetRow][Math.Min(targetCol + counter, matrix[targetRow].Length - 1)] == ' ')
                                {
                                    freeRow = targetRow;
                                    freeCol = Math.Min(targetCol + counter, matrix[targetRow].Length - 1);
                                    breakTheLoop = true;
                                    break;
                                }
                            }

                            oddCOunter++;
                            if (counter > matrix[targetRow].Length)
                            {
                                Console.WriteLine($"Row {targetRow} full");
                                parkingNotFull = false;
                                breakTheLoop = true;
                                break;
                            }

                        }

                        if (breakTheLoop)
                        {
                            break;
                        }
                    }

                }

                if (parkingNotFull)
                {
                    matrix[freeRow][freeCol] = 'C';
                    var moveDistance = Math.Abs(entryRow - freeRow) + freeCol + 1;
                    Console.WriteLine($"{moveDistance}");
                }

            }

        }
    }
}