namespace _09_StackFibonacci
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            var numberToSearch = int.Parse(Console.ReadLine());
            var allNumbers = new Stack<long>();
            allNumbers.Push(0);
            allNumbers.Push(1);

            for (int i = 1; i < numberToSearch; i++)
            {
                var lastNumber = allNumbers.Pop();
                var oneBeforeLastNumber = allNumbers.Peek();
                var numberToAdd = lastNumber + oneBeforeLastNumber;

                allNumbers.Push(lastNumber);
                allNumbers.Push(numberToAdd);
            }

            Console.WriteLine(allNumbers.Peek());
        }
    }
}
