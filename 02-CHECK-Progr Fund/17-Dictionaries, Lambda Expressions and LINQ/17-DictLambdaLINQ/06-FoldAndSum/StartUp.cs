namespace _06_FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> allNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> firstPart = new List<int>();
            List<int> midPart = new List<int>();
            List<int> lastPart = new List<int>();
            List<int> firstRow = new List<int>();
            List<int> secondRow = new List<int>();

            firstPart.AddRange(allNumbers.Take(allNumbers.Count/4).Reverse());
            midPart.AddRange(allNumbers.Skip(allNumbers.Count / 4).Take((allNumbers.Count / 2)));
            lastPart.AddRange(allNumbers.Skip((allNumbers.Count / 4) * 3).Take(allNumbers.Count / 4).Reverse());

            firstRow.AddRange(firstPart);
            firstRow.AddRange(lastPart);
            secondRow.AddRange(midPart);

            List<int> result = new List<int>();


            for (int i = 0; i < secondRow.Count; i++)
            {
                result.Add(firstRow[i]+secondRow[i]);

            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}