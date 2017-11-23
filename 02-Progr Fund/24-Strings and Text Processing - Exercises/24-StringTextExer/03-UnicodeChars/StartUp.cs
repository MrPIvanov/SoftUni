using System;

namespace _03_UnicodeChars
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            foreach (var chr in input)
            {
                Console.Write("\\u{0:x4}", (int)chr);
            }
            Console.WriteLine();

        }
    }
}