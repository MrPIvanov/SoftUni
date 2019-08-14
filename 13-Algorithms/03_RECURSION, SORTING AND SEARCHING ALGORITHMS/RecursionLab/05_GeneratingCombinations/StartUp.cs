using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var numberOfElements = int.Parse(Console.ReadLine());

        var tempArr = new int[numberOfElements];
        var index = 0;
        var border = 0;

        GenComb(numbers, tempArr, index, border);

    }

    private static void GenComb(int[] numbers, int[] tempArr, int index, int border)
    {
        if (index >= tempArr.Length)
        {
            Console.WriteLine(string.Join(" ", tempArr));
            return;
        }

        for (int i = border; i < numbers.Length; i++)
        {
            tempArr[index] = numbers[i];
            GenComb(numbers, tempArr, index + 1, i + 1);
        }
    } 
}