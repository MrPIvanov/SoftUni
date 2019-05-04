using System;

public class StartUp
{
    public static void Main()
    {
        var input = int.Parse(Console.ReadLine());

        var vector = new int[input];

        var index = 0;

        Gen(vector, index);
    }

    private static void Gen(int[] vector, int index)
    {
        if (index > vector.Length - 1)
        {
            Console.WriteLine(string.Join("", vector));
            return;
        }

        for (int i = 0; i <= 1; i++)
        {
            vector[index] = i;
            Gen(vector, index + 1);
        }
    }
}