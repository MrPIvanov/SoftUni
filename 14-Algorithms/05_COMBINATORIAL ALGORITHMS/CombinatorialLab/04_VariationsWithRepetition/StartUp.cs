using System;
using System.Linq;

public class StartUp
{
    static char[] set;
    static char[] variation;

    public static void Main()
    {
        set = Console.ReadLine()
            .Split()
            .Select(Char.Parse)
            .ToArray();

        int k = int.Parse(Console.ReadLine());

        variation = new char[k];

        Variate(0);
    }

    public static void Variate(int index)
    {
        if (index >= variation.Length)
        {
            Console.WriteLine(string.Join(" ", variation));
        }
        else
        {
            for (int i = 0; i < set.Length; i++)
            {
                variation[index] = set[i];
                Variate(index + 1);
            }
        }
    }
}