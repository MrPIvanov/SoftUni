using System;
using System.Collections.Generic;
using System.IO;

namespace _04_PunctuationFinder
{
    public class StartUp
    {
        public static void Main()
        {
            var allText = File.ReadAllText(@"D:\SoftUni\02-Progr Fund\20-Objects and Classes - Exercises\Resources\sample_text.txt").ToCharArray();
            var result = new List<char>();

            foreach (var letter in allText)
            {
                if (letter=='.' || letter == ',' || letter == '!' || letter == '?' || letter == ':')
                {

                    result.Add(letter);
                }

            }
            Console.WriteLine(string.Join(", ", result));

        }
    }
}