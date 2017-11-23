using System;

namespace _10_sumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < lines; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                result += (int)currentChar;
            }

            Console.WriteLine($"The sum equals: {result}");






        }
    }
}