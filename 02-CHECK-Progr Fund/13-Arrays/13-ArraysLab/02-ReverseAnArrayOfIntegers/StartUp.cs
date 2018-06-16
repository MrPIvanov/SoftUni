namespace _02_ReverseAnArrayOfIntegers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int numberCount = int.Parse(Console.ReadLine());

            int[] array = new int[numberCount];

            for (int i = 0; i < numberCount; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}