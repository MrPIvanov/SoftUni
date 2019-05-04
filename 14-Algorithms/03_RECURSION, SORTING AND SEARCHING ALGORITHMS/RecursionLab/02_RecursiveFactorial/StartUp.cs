using System;

public class StartUp
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        var result = Factorial(number);

        Console.WriteLine(result);
    }

    private static int Factorial(int number)
    {
        if (number == 1)
        {
            return 1;
        }

        return number * Factorial(number - 1);
    }
}