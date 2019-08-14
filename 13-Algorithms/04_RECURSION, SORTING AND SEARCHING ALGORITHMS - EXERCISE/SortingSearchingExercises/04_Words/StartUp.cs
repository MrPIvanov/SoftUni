using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    private static char[] chars;
    private static int counter;

    public static void Main()
    {
        chars = Console.ReadLine().ToCharArray();

        counter = 0;

        if (chars.Length == chars.Distinct().ToArray().Length)
        {
            counter = 1;

            for (int i = 1; i <= chars.Length; i++)
            {
                counter *= i;
            }
        }
        else
        {
            Gen(0);
        }

        Console.WriteLine(counter);
    }

    public static void Gen(int index)
    {
        if (index >= chars.Length)
        {
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[i - 1])
                {
                    return;
                }
            }
            counter++;
        }

        else
        {
            HashSet<int> swapped = new HashSet<int>();
            for (int i = index; i < chars.Length; i++)
            {
                if (!swapped.Contains(chars[i]))
                {

                    Swap(chars, index, i);

                    Gen(index + 1);

                    Swap(chars, index, i);

                    swapped.Add(chars[i]);

                }

            }
        }
    }

    private static void Swap(char[] chars, int first, int second)
    {
        var temp = chars[first];
        chars[first] = chars[second];
        chars[second] = temp;
    }
}