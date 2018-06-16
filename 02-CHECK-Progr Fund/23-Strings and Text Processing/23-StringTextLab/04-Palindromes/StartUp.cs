using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Palindromes
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' },StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();

            foreach (var word in text)
            {
                string wordReversed = string.Join("", word.ToCharArray().Reverse());

                if (word == wordReversed)
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",result.Distinct().OrderBy(x=>x)));

        }
    }
}