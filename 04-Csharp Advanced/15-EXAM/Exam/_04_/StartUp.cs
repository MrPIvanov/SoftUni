using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var knivesArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var forksArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var knives = new Stack<int>(knivesArr);

        var forks = new Queue<int>(forksArr);

        var maxSet = 0; // ???

        var maxCollection = new List<int>();

        while (knives.Count > 0 && forks.Count > 0)
        {
            var currentSet = 0;

            var knive = knives.Peek();
            var fork = forks.Peek();

            if (knive > fork)
            {
                // set
                currentSet += (knive + fork);

                maxCollection.Add(currentSet);
                knives.Pop();
                forks.Dequeue();
            }

            else if (fork > knive)
            {
                knives.Pop();
            }
            else
            {
                forks.Dequeue();
                var temp = knives.Pop();
                temp++;
                knives.Push(temp);
            }
        }

        Console.WriteLine($"The biggest set is: {maxCollection.Max()}");
        Console.WriteLine(string.Join(" ", maxCollection));
    }
}