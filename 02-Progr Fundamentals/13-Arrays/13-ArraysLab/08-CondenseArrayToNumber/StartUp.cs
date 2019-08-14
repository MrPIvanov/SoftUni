namespace _08_CondenseArrayToNumber
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] allNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] newArrayNumbers = new int[allNumbers.Length];
            int loops = allNumbers.Length-1;

            if (allNumbers.Length!=1)
            {
                for (int y = 0; y < loops; y++)
                {
                    for (int i = 0; i < loops - y; i++)
                    {
                        newArrayNumbers[i] = allNumbers[i] + allNumbers[i + 1];
                    }

                    allNumbers = allNumbers.Reverse().Skip(1).Reverse().ToArray();
                    newArrayNumbers = newArrayNumbers.Reverse().Skip(1).Reverse().ToArray();

                    for (int z = 0; z < newArrayNumbers.Length; z++)
                    {
                        allNumbers[z] = newArrayNumbers[z];
                    }
                }

                Console.Write($"{newArrayNumbers[0]}");
            }
            else
            {
                Console.WriteLine(allNumbers[0]);
            }

        }
    }
}