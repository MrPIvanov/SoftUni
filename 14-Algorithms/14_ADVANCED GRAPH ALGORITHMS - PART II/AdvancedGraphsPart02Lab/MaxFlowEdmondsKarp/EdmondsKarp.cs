﻿using System.Collections.Generic;

public class EdmondsKarp
{
    private static int[][] graph;
    private static int[] parents;

    public static int FindMaxFlow(int[][] targetGraph)
    {
        graph = targetGraph;
        parents = new int[graph.Length];

        for (int i = 0; i < graph.Length; i++)
        {
            parents[i] = -1;
        }

        int maxFlow = 0;
        int start = 0;
        int end = graph.Length - 1;

        while (BFS(start, end))
        {
            int pathFlow = int.MaxValue;
            int currentNode = end;

            while (currentNode != start)
            {
                int previousNode = parents[currentNode];

                if (graph[previousNode][currentNode] < pathFlow)
                {
                    pathFlow = graph[previousNode][currentNode];
                }

                currentNode = previousNode;
            }

            maxFlow += pathFlow;
            currentNode = end;

            while (currentNode != start)
            {
                int previousNode = parents[currentNode];
                graph[previousNode][currentNode] -= pathFlow;
                graph[currentNode][previousNode] += pathFlow;
                currentNode = previousNode;
            }
        }

        return maxFlow;
    }

    private static bool BFS(int start, int end)
    {
        var visited = new bool[graph.Length];

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int currentNode = queue.Dequeue();
            visited[currentNode] = true;

            for (int child = 0; child < graph[currentNode].Length; child++)
            {
                if (!visited[child] && graph[currentNode][child] > 0)
                {
                    queue.Enqueue(child);
                    parents[child] = currentNode;
                }
            }
        }

        return visited[end];
    }
}
