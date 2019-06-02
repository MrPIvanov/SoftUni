using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numberOfMolecules = int.Parse(Console.ReadLine());
        var nodes = new Dictionary<int, Node>();
        var graph = new Dictionary<Node, Dictionary<Node, int>>();

        for (int i = 1; i <= numberOfMolecules; i++)
        {
            nodes.Add(i, new Node(i));
            graph.Add(nodes[i], new Dictionary<Node, int>());
        }


        var connections = int.Parse(Console.ReadLine());
        for (int i = 0; i < connections; i++)
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var from = line[0];
            var to = line[1];
            var weight = line[2];

            //{nodes[3], new Dictionary<Node,int>() { {nodes[10], 7}}},

            graph[nodes[from]].Add(nodes[to], weight);
        }

        var lastLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var startMolecule = lastLine[0];
        var endMolecule = lastLine[1];

        PrintPath(graph, nodes, startMolecule, endMolecule);
    }

    public static void PrintPath(Dictionary<Node, Dictionary<Node, int>> graph, Dictionary<int, Node> nodes, int sourceNode, int destinationNode)
    {
        var path = DijkstraWithPriorityQueue.DijkstraAlgorithm(graph, nodes[sourceNode], nodes[destinationNode]);

        
        Console.WriteLine(nodes[destinationNode].DistanceFromStart);


        foreach (var node in nodes)
        {
            if (nodes[node.Key].DistanceFromStart == double.PositiveInfinity)
            {
                Console.Write($"{node.Key} ");
            }
        }
    }
}

public class PriorityQueue<T> where T : IComparable<T>
{
    private Dictionary<T, int> searchCollection;
    private List<T> heap;

    public PriorityQueue()
    {
        this.heap = new List<T>();
        this.searchCollection = new Dictionary<T, int>();
    }

    public int Count
    {
        get
        {
            return this.heap.Count;
        }
    }

    public T ExtractMin()
    {
        var min = this.heap[0];
        var last = this.heap[this.heap.Count - 1];
        this.searchCollection[last] = 0;
        this.heap[0] = last;
        this.heap.RemoveAt(this.heap.Count - 1);
        if (this.heap.Count > 0)
        {
            this.HeapifyDown(0);
        }

        this.searchCollection.Remove(min);

        return min;
    }

    public T PeekMin()
    {
        return this.heap[0];
    }

    public void Enqueue(T element)
    {
        this.searchCollection.Add(element, this.heap.Count);
        this.heap.Add(element);
        this.HeapifyUp(this.heap.Count - 1);
    }

    private void HeapifyDown(int i)
    {
        var left = (2 * i) + 1;
        var right = (2 * i) + 2;
        var smallest = i;

        if (left < this.heap.Count && this.heap[left].CompareTo(this.heap[smallest]) < 0)
        {
            smallest = left;
        }

        if (right < this.heap.Count && this.heap[right].CompareTo(this.heap[smallest]) < 0)
        {
            smallest = right;
        }

        if (smallest != i)
        {
            T old = this.heap[i];
            this.searchCollection[old] = smallest;
            this.searchCollection[this.heap[smallest]] = i;
            this.heap[i] = this.heap[smallest];
            this.heap[smallest] = old;
            this.HeapifyDown(smallest);
        }
    }

    private void HeapifyUp(int i)
    {
        var parent = (i - 1) / 2;
        while (i > 0 && this.heap[i].CompareTo(this.heap[parent]) < 0)
        {
            T old = this.heap[i];
            this.searchCollection[old] = parent;
            this.searchCollection[this.heap[parent]] = i;
            this.heap[i] = this.heap[parent];
            this.heap[parent] = old;

            i = parent;
            parent = (i - 1) / 2;
        }
    }

    public void DecreaseKey(T element)
    {
        int index = this.searchCollection[element];
        this.HeapifyUp(index);
    }
}

public class Node : IComparable<Node>
{
    // set default value for the distance equal to positive infinity
    public Node(int id, double distance = double.PositiveInfinity)
    {
        this.Id = id;
        this.DistanceFromStart = distance;
    }

    public int Id { get; set; }

    public double DistanceFromStart { get; set; }

    public int CompareTo(Node other)
    {
        return this.DistanceFromStart.CompareTo(other.DistanceFromStart);
    }
}

public static class DijkstraWithPriorityQueue
{
    public static List<int> DijkstraAlgorithm(Dictionary<Node, Dictionary<Node, int>> graph, Node sourceNode, Node destinationNode)
    {
        bool[] visited = new bool[graph.Count + 1];
        int?[] previous = new int?[graph.Count + 1];
        PriorityQueue<Node> priorityQueue = new PriorityQueue<Node>();

        foreach (var kvp in graph)
        {
            kvp.Key.DistanceFromStart = double.PositiveInfinity;
        }

        sourceNode.DistanceFromStart = 0;
        priorityQueue.Enqueue(sourceNode);

        while (priorityQueue.Count > 0)
        {
            Node minNode = priorityQueue.ExtractMin();

            //if (minNode == destinationNode)
            //{
            //    break;
            //}

            foreach (var kvp in graph[minNode])
            {
                if (!visited[kvp.Key.Id])
                {
                    priorityQueue.Enqueue(kvp.Key);
                    visited[kvp.Key.Id] = true;
                }

                double distance = minNode.DistanceFromStart + kvp.Value;

                if (distance < kvp.Key.DistanceFromStart)
                {
                    kvp.Key.DistanceFromStart = distance;
                    previous[kvp.Key.Id] = minNode.Id;
                    priorityQueue.DecreaseKey(kvp.Key);
                }
            }
        }

        if (double.IsInfinity(destinationNode.DistanceFromStart))
        {
            return null;
        }

        List<int> path = new List<int>();
        int? current = destinationNode.Id;

        while (current != null)
        {
            path.Add(current.Value);
            current = previous[current.Value];
        }

        path.Reverse();

        return path;
    }
}