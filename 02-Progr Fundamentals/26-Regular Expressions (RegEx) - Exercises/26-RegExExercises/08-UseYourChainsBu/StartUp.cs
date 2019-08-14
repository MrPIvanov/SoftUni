using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08_UseYourChainsBu
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"<p>(.*?)<\/p>";
            var rawMatches = new List<string>();

            MatchCollection allMatches = Regex.Matches(text,pattern);

            foreach (Match item in allMatches)
            {
                rawMatches.Add(item.Groups[1].Value);
            }

            var rawText = "";
            foreach (var match in rawMatches)
            {
                rawText += match;
            }

            var onlyLettersAndSpace = "";
            foreach (var letter in rawText)
            {
                if ((letter>96 && letter<123) || (letter>47 && letter<58))
                {
                    onlyLettersAndSpace += letter;
                }
                else
                {
                    onlyLettersAndSpace += " ";
                }
            }

            onlyLettersAndSpace = onlyLettersAndSpace.Trim();
            var singleSpaceText = "";

            for (int i = 0; i < onlyLettersAndSpace.Length; i++)
            {
                if (onlyLettersAndSpace[i] == ' ' && onlyLettersAndSpace[i + 1] == ' ')
                {
                    continue;

                }
                singleSpaceText += onlyLettersAndSpace[i];

            }

            var result = "";

            foreach (var letter in singleSpaceText)
            {
                if (letter>96 && letter<110 )
                {
                    int current = (int.Parse)((letter + 13).ToString());
                    char currentChar = Convert.ToChar(current);
                    result += currentChar;
                }
                else if (letter>109 && letter < 123)
                {
                    int current = (int.Parse)((letter - 13).ToString());
                    char currentChar = Convert.ToChar(current);
                    result += currentChar;
                }
                else
                {
                    result += $"{letter}";
                }
                
            }

            Console.WriteLine(result.Trim());

        }
    }
}