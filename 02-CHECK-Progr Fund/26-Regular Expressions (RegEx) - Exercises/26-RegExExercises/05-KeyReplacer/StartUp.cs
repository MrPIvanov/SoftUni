using System;
using System.Text.RegularExpressions;

namespace _05_KeyReplacer
{
    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"^([a-zA-Z]+)(?=[\|<\\]).+(?<=[\|<\\])([a-zA-Z]+)";

            var key = Console.ReadLine();
            var text = Console.ReadLine();

            Match match = Regex.Match(key,pattern);

            var startWord = match.Groups[1];
            var endWord = match.Groups[2];

            var endResult = "";

            var replacePattern = $@"{startWord}(.*?){endWord}";

            MatchCollection matches = Regex.Matches(text,replacePattern);

            foreach (Match word in matches)
            {
                endResult += word.Groups[1];
            }

            if (endResult.Length>0)
            {
                Console.WriteLine(endResult);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}