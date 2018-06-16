using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06_ValidUsernames
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"(?<=^|([ \/\\(\)]))(?<name>[a-zA-Z]{1}[a-zA-Z0-9_]{2,24})(?=$|([ \/\\(\)]))";
            var allNames = new List<string>();

            MatchCollection allMatches = Regex.Matches(text,pattern);

            foreach (Match name in allMatches)
            {
                var nameToAdd = name.Groups["name"].Value;
                allNames.Add(nameToAdd);
            }

            var firstName = "";
            var secondName = "";
            var lenghtCounter = 0;

            for (int i = 0; i < allNames.Count-1; i++)
            {
                if (allNames[i].Length+allNames[i+1].Length>lenghtCounter)
                {
                    firstName = allNames[i];
                    secondName = allNames[i + 1];
                    lenghtCounter = allNames[i].Length + allNames[i + 1].Length;

                }

            }

            Console.WriteLine(firstName);
            Console.WriteLine(secondName);

        }
    }
}