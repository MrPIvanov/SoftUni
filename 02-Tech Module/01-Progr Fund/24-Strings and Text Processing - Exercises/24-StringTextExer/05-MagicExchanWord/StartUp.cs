using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_MagicExchanWord
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split().ToArray();
            char[] firstWord = words[0].ToCharArray();
            char[] secondWoed = words[1].ToCharArray();



            char[] clearFirst = firstWord.Distinct().ToArray();
            char[] clearSecond = secondWoed.Distinct().ToArray();

            if (clearFirst.Length==clearSecond.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}