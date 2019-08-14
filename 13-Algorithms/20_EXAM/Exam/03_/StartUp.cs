using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var resultStrings = new List<string>();
        var single = new List<int>();
        var comb = new List<int>();

        single.Add(0);
        comb.Add(0);
        comb.Add(0);
        single.AddRange(Console.ReadLine().Split().Select(int.Parse).ToArray());
        comb.AddRange(Console.ReadLine().Split().Select(int.Parse).ToArray());

        var sums = new int[single.Count];
        var prev = new int[single.Count];

        sums[0] = 0;
        sums[1] = single[1];
        prev[1] = 1;

        for (int index = 2; index < single.Count; index++)
        {
            var fromDouble = sums[index - 2] + comb[index];
            var fromSingle = sums[index - 1] + single[index];

            if (fromDouble > fromSingle)
            {
                prev[index] = 1;
            }
            if (fromDouble < fromSingle)
            {
                prev[index] = 2;
            }
            if (fromDouble == fromSingle)
            {
                prev[index] = 3;
            }

            sums[index] = Math.Min(fromDouble, fromSingle);
        }

        FindPath(resultStrings,prev);


        resultStrings.Reverse();
        Console.WriteLine($"Optimal Time: { sums[single.Count - 1]}");
        Console.WriteLine(string.Join(Environment.NewLine, resultStrings));
    }

    private static void FindPath(List<string> resultStrings, int[] prev)
    {
        for (int index = prev.Length - 1; index > 0; index--)
        {
            if (prev[index] == 1)
            {
                resultStrings.Add($"Single {index}");
            }
            else if(prev[index] == 2)
            {
                resultStrings.Add($"Pair of {index - 1} and {index}");
                index--;
            }
            else
            {
                resultStrings.Add($"Single {index}");
            }
        }
    }
}