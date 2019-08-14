namespace _03_WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            StreamReader readerWords = new StreamReader(@"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\Resources\words.txt");
            StreamReader readerText = new StreamReader(@"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\Resources\text.txt");
            StreamWriter writer = new StreamWriter(@"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\HomeWorkResults\03-WordCount.txt");

            var wordsToSearch = new List<string>();
            using (readerWords)
            {
                var word = readerWords.ReadLine();
                while (word != null)
                {
                    wordsToSearch.Add(word);
                    word = readerWords.ReadLine();
                }

            }

            var textToSearch = "";
            using (readerText)
            {
                var line = readerText.ReadLine();
                while (line != null)
                {
                    textToSearch += line;
                    line = readerText.ReadLine();
                }
            }

            var allWords = textToSearch.Split(new char[] { '-', ',', '.', '?', '!', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = new Dictionary<string, int>();

            foreach (var word in wordsToSearch)
            {
                result.Add(word, 0);
                foreach (var item in allWords)
                {
                    if (word == item.ToLower())
                    {
                        result[word]++;
                    }
                }
            }

            result = result.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            using (writer)
            {
                foreach (var word in result)
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}