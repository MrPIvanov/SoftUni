namespace _03_AnonymousVox
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var values = Console.ReadLine().Split(new string[] {"}{" },StringSplitOptions.RemoveEmptyEntries).ToList();
            values[0] = values[0].Substring(1);
            values[values.Count - 1] = values[values.Count - 1].Substring(0, values[values.Count - 1].Length - 1);
            var pattern = @"([a-zA-Z]+)(.*)\1";
            var indexCounter = 0;

            MatchCollection allMatches = Regex.Matches(text,pattern);

            foreach (Match match in allMatches)
            {
                var strToReplace = match.Groups[1].Value.ToString() + values[indexCounter] + match.Groups[1].Value.ToString();
                text = text.Replace(match.ToString(), strToReplace);
                indexCounter++;
            }
            Console.WriteLine(text);
            

        }
    }
}