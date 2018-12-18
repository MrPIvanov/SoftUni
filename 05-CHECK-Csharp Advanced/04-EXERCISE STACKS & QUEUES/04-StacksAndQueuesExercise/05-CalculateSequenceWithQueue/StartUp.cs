namespace _05_CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var result = new List<long>();

            var allNumbers = new Queue<long>();
            allNumbers.Enqueue(number);

            for (int i = 0; i < 17; i++)
            {
                var currentNumber = allNumbers.Dequeue();
                result.Add(currentNumber);

                allNumbers.Enqueue(currentNumber + 1);
                allNumbers.Enqueue(2 * currentNumber + 1);
                allNumbers.Enqueue(currentNumber + 2);

            }

            result.AddRange(allNumbers);

            Console.Write(string.Join(" ",result.Take(50)));

        }
    }
}
