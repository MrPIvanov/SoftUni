namespace _01_MatrixOfPalindromes
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var rows = input[0];
            var columns = input[1];
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < rows; i++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Console.Write($"{alphabet[i]}{alphabet[i+y]}{alphabet[i]} ");

                }
                Console.WriteLine();
            }


        }
    }
}
