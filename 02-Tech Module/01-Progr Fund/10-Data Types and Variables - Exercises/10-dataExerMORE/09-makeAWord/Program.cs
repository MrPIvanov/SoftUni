using System;

namespace _09_makeAWord
{
    class Program
    {
        static void Main(string[] args)
        {

            int letters = int.Parse(Console.ReadLine());

            string result = "";
            for (int i = 0; i < letters; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                result += currentChar;
            }

            Console.WriteLine($"The word is: {result}");





        }
    }
}