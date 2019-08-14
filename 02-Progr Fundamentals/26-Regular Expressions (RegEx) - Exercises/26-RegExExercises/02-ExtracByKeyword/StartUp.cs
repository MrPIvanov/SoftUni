using System;
using System.Text.RegularExpressions;

namespace _02_ExtracByKeyword
{
    public class StartUp
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string pattern = @"\b[^?.!]*\b"+word + @"\b[^?.!]*";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m);
            }
        }
    }
}