namespace _03_FoldAndSum
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] firstNewArray = new int[(input.Length)/2];
            int[] secondNewArray = new int[(input.Length) / 2];

            for (int i = 0; i <= secondNewArray.Length-1; i++)
            {
                secondNewArray[i] = input[input.Length/4+i];
            }

            int x = 0;
            for (int i = input.Length/4-1; i >= 0; i--)
            {
                firstNewArray[i] = input[x];
                x++;
            }

            int z = 0;
            for (int y = input.Length / 4; y <= firstNewArray.Length-1; y++)
            {
                firstNewArray[y] = input[input.Length-1-z];
                z++;
            }

            int[] endResult = new int[firstNewArray.Length];
            for (int i = 0; i <= endResult.Length-1; i++)
            {
                endResult[i] = firstNewArray[i] + secondNewArray[i];
            }

            Console.WriteLine(string.Join(" ", endResult));
        }
    }
}