using System;

namespace _13_decrypting
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 0; i < lines; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                int newInt = (int)currentChar + key;
                char newChar = (char)newInt;

                result +=newChar;

            }

            Console.WriteLine(result);

        }
    }
}