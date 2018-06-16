namespace _03_Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var oddCOunter = 0;

            var didiMonRegex = @"([^a-zA-Z-]+)(.*$)";
            var bojoMoneRegex = @"([a-zA-Z]+-[a-zA-Z]+)(.*$)";

            while (text.Length>0)
            {
                oddCOunter++;
                if (oddCOunter%2==1)
                {
                    Match match = Regex.Match(text, didiMonRegex);
                    Console.WriteLine(match.Groups[1].Value);
                    text = match.Groups[2].Value;
                }
                else
                {
                    Match match = Regex.Match(text, bojoMoneRegex);
                    Console.WriteLine(match.Groups[1].Value);
                    text = match.Groups[2].Value;
                }

            }
        }
    }
}