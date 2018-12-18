namespace _02_DiagonalDifference
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var sideLenght = int.Parse(Console.ReadLine());

            var matrix = new int[sideLenght][];

            for (int i = 0; i < sideLenght; i++)
            {
                var temp = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

                matrix[i] = temp.ToArray();
            }

            var firstDiagonalSum = 0;
            var secondDiagonalSum = 0;

            for (int row = 0; row < sideLenght; row++)
            {
                firstDiagonalSum += matrix[row][row];
                secondDiagonalSum += matrix[row][sideLenght - row-1];

            }

            Console.WriteLine(Math.Abs(firstDiagonalSum-secondDiagonalSum));
        }
    }
}