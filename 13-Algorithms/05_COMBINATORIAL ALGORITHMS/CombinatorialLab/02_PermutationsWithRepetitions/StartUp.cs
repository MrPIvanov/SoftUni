using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var letters = Console.ReadLine().Split().ToArray();

        Generate(letters, 0);
    }

    private static void Generate(string[] letters, int index)
    {
        if (index >= letters.Length)
        {
            Console.WriteLine(string.Join(" ", letters));
        }
        else
        {
            Generate(letters, index + 1);

            var used = new HashSet<string> { letters[index] };

            for (int i = index + 1; i < letters.Length; i++)
            {
                if (!used.Contains(letters[i]))
                {
                    used.Add(letters[i]);
                    Swap(letters, index, i);
                    Generate(letters, index + 1);
                    Swap(letters, index, i);
                }
               
            }
        }
    }

    private static void Swap(string[] letters, int index, int i)
    {
        var temp = letters[index];
        letters[index] = letters[i];
        letters[i] = temp;
    }
}