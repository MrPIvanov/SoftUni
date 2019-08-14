namespace _03_WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allText = File.ReadAllText(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\Resources\03. Word Count\text.txt")
                .ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },StringSplitOptions.RemoveEmptyEntries).ToList();

            var allWords = File.ReadAllText(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\Resources\03. Word Count\words.txt")
                .ToLower().Split().ToList();

            var endResult = new Dictionary<string, int>();

            for (int i = 0; i < allWords.Count; i++)
            {
                endResult[allWords[i]] = 0;
            }

            for (int i = 0; i < allWords.Count; i++)
            {
                for (int t = 0; t < allText.Count; t++)
                {
                    if (allText[t] == allWords[i])
                    {
                        endResult[allWords[i]]++;
                    }
                }
            }

            File.Delete(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\03-WordCount.txt");

            foreach (var word in endResult.OrderByDescending(x=>x.Value))
            {
                var lineToAppend = $"{word.Key} - {word.Value}{Environment.NewLine}";
                File.AppendAllText(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\03-WordCount.txt", lineToAppend);
            }

        }
    }
}