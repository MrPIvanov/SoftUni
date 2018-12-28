using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        var queue = new Queue<int>();

        queue.Enqueue(number);

        var allNumbersToPrint = new List<int>();
        var numbersShown = 0;

        while (numbersShown != 50)
        {
            var currentNumber = queue.Dequeue();

            queue.Enqueue(currentNumber + 1);
            queue.Enqueue(2 * currentNumber + 1);
            queue.Enqueue(currentNumber + 2);

            numbersShown++;
            allNumbersToPrint.Add(currentNumber);
        }

        Console.WriteLine(string.Join(", ", allNumbersToPrint));
    }
}