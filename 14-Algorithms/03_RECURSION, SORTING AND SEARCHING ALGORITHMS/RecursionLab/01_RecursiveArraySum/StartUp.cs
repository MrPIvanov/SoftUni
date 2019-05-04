using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var startIndex = 0;

       var total =  Sum(numbers, startIndex);

        Console.WriteLine(total);
    }

    private static int Sum(int[] numbers, int index)
    {
        if (index == numbers.Length)
        {
            return 0;
        }

        return numbers[index++] + Sum(numbers, index);
    }
}