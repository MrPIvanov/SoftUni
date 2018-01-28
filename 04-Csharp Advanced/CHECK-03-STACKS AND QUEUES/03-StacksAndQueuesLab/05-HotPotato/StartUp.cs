namespace _05_HotPotato
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var players = Console.ReadLine().Split(' ');
            var tossCount = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(players);

            while (queue.Count>1)
            {
                for (int i = 1; i < tossCount; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
