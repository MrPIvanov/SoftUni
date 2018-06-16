namespace _03_GroupNumbers
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var firstRowLenght = 0;
            var secondRowLenght = 0;
            var thirdRowLenght = 0;

            foreach (var item in input)
            {
                if (Math.Abs(item)%3==0)
                {
                    firstRowLenght++;
                }
                else if (Math.Abs(item) % 3==1)
                {
                    secondRowLenght++;
                }
                else
                {
                    thirdRowLenght++;
                }
            }

            int[][] result = new int[3][];

            result[0] = new int[firstRowLenght];
            result[1] = new int[secondRowLenght];
            result[2] = new int[thirdRowLenght];

            var firstRowIndex = 0;
            var secondRowIndex = 0;
            var thirdRowIndex = 0;

            foreach (var item in input)
            {
                if (Math.Abs(item) % 3 == 0)
                {
                    result[0][firstRowIndex] = item;
                    firstRowIndex++;
                }
                else if (Math.Abs(item) % 3 == 1)
                {
                    result[1][secondRowIndex] = item;
                    secondRowIndex++;
                }
                else
                {
                    result[2][thirdRowIndex] = item;
                    thirdRowIndex++;
                }

            }

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result[row].Length; col++)
                {
                    Console.Write(result[row][col]+ " ");
                }
                Console.WriteLine();
            }






        }
    }
}