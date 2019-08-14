using System;

public class StartUp
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        var fibNumbers = new long[number + 1];

        fibNumbers[0] = 0;
        fibNumbers[1] = 1;
        fibNumbers[2] = 2;

        var result = CalcFib(number - 1, fibNumbers);

        Console.WriteLine(result);
    }

    private static long CalcFib(int number, long[] fibNumbers)
    {
        if (fibNumbers[number] != 0)
        {
            return fibNumbers[number];
        }

        var result = CalcFib(number - 1, fibNumbers) + CalcFib(number - 2, fibNumbers);

        fibNumbers[number] = result;

        return result;
    }
}