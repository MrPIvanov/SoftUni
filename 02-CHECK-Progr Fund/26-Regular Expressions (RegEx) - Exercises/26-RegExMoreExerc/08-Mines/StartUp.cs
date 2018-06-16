using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08_Mines
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"<..>";
            var allMines = new List<string>();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match mine in matches)
            {
                allMines.Add(mine.ToString());
            }

            for (int i = 0; i < allMines.Count; i++)
            {
                var firstChar = allMines[i][1];
                var secondChar = allMines[i][2];

                int blastRadius = Math.Abs(firstChar-secondChar);

                var mineIndex = text.IndexOf(allMines[i]);
                var startIndex = Math.Max(mineIndex - blastRadius, 0);
                var endIndex = Math.Min(text.Length,mineIndex+4+blastRadius);

                var textToReplace = text.Substring(startIndex, endIndex-startIndex );

                text = text.Replace(textToReplace, new string('_', textToReplace.Length));
            }

            Console.WriteLine(text);
        }
    }
}