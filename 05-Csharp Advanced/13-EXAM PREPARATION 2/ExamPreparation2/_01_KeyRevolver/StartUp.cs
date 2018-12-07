using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var bulletPrice = int.Parse(Console.ReadLine());
        var barrelSize = int.Parse(Console.ReadLine());
        var bulletArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var lockArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var intelligenceValue = int.Parse(Console.ReadLine());

        var bullets = new Stack<int>(bulletArr);
        var locks = new Queue<int>(lockArr);

        int shotsCounter = 0;
        while (true)
        {
            var currentBullet = bullets.Peek();
            var currentLock = locks.Peek();

            shotsCounter++;
            bullets.Pop();

            if (currentBullet <= currentLock)
            {
                Console.WriteLine("Bang!");
                locks.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            if (shotsCounter == barrelSize && bullets.Count > 0)
            {
                Console.WriteLine("Reloading!");
                shotsCounter = 0;
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligenceValue - (bulletArr.Length - bullets.Count) * bulletPrice}");
                break;
            }

            if (bullets.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                break;
            }
        }
    }
}