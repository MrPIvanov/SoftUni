namespace _04_BasicQueueOperations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var numbersCount = input[0];
            var numbersToRemove = input[1];
            var numberToCheck = input[2];

            var allNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var queue = new Queue<int>(allNumbers);

            for (int i = 0; i < numbersToRemove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count==0)
            {
                Console.WriteLine("0");
            }

            else if(queue.Contains(numberToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }


        }
    }
}
