namespace _07_LegoBlocks
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var firstArray = new int[n][];
            var secondArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                firstArray[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            for (int i = 0; i < n; i++)
            {
                secondArray[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            ReverseTheArray(secondArray);

            var totalSumbols = 0;
            var sumbolsCountToCheck = firstArray[0].Length + secondArray[0].Length;
            bool isLengthTheSame = true;
            for (int i = 0; i < n; i++)
            {
                totalSumbols += firstArray[i].Length;
                totalSumbols += secondArray[i].Length;

                if (firstArray[i].Length + secondArray[i].Length == sumbolsCountToCheck)
                {
                    continue;
                }
                isLengthTheSame = false;
            }

            if (isLengthTheSame)
            {
                PrintArrays(firstArray,secondArray);
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalSumbols}");
            }
        }

        private static void PrintArrays(int[][] firstArray, int[][] secondArray)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                var temp = firstArray[i].ToList();
                temp.AddRange(secondArray[i]);
                Console.WriteLine($"[{string.Join (", ",temp)}]");
            }
        }

        private static void ReverseTheArray(int[][] secondArray)
        {
            for (int i = 0; i < secondArray.Length; i++)
            {
                var temp = secondArray[i];
                secondArray[i] = temp.Reverse().ToArray();

            }
        }
    }
}