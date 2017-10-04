using System;

namespace _03_printTria
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                PrintSingleLine(1, i);
            }

            PrintSingleLine(1, number);

            for (int i = number-1; i >= 1; i--)
            {
                PrintSingleLine(1, i);
            }




        }

        static void PrintSingleLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

        }
    }
}