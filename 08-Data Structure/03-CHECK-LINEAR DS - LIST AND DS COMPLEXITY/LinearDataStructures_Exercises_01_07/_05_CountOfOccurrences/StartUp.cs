using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_CountOfOccurrences
{
    public class StartUp
    {
        static void Main()
        {
            var allNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var resultDict = new Dictionary<int, int>();

            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (! resultDict.ContainsKey(allNumbers[i]))
                {
                    resultDict.Add(allNumbers[i], 0);
                }

                resultDict[allNumbers[i]]++;
            }

            foreach (var set in resultDict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{set.Key} -> {set.Value} times");
            }
        }
    }
}