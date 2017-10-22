namespace _06_MaxSequenceOfEqualElement
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] allNUmbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestStart = 0;
            int bestLenght = 1;

            int newBestStart = 0;
            int newBestLenght = 1;


            for (int  i = 1;  i <= allNUmbers.Length-1;  i++)
            {
                if (allNUmbers[i]==allNUmbers[i-1])
                {
                    newBestLenght++;
                }
                else
                {
                    newBestStart = i;
                    newBestLenght =1;
                    
                }

                if (newBestLenght>bestLenght)
                {
                    bestLenght = newBestLenght;
                    bestStart = newBestStart;
                }

            }

            for (int i =0; i < bestLenght; i++)
            {
                Console.Write($"{allNUmbers[bestStart+i]} ");

            }
        }
    }
}