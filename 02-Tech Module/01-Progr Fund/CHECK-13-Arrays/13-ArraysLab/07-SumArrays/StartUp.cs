namespace _07_SumArrays
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int firstLenght = firstArray.Length;
            int secondLenght = secondArray.Length;

            int loops = Math.Max(firstLenght,secondLenght);

            for (int i = 0; i < loops; i++)
            {
                Console.Write($"{firstArray[i%firstLenght] + secondArray[i%secondLenght]} ");
            }
        }
    }
}