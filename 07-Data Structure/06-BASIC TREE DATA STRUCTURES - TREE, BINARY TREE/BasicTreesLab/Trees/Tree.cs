using System;
using System.Collections;
using System.Collections.Generic;

public class Tree<T>
{
    public T Value { get; set; }

    public IList<Tree<T>> Children { get; private set; }


    public Tree(T value, params Tree<T>[] children)
    {
        this.Value = value;
        this.Children = new List<Tree<T>>(children);
    }

    public void Print(int indent = 0)
    {
        this.Print(this, indent);
    }

    private void Print(Tree<T> node, int indent)
    {
        Console.WriteLine($"{new string(' ', 2 * indent)}{node.Value}");

        foreach (var child in node.Children)
        {
            this.Print(child, indent + 1);
        }
    }

    public void Each(Action<T> action)
    {
        action(this.Value);

        foreach (var child in this.Children)
        {
            child.Each(action);
        }
    }

    public IEnumerable<T> OrderDFS()
    {
        var result = new List<T>();

        this.DFS(this, result);

        return result;
    }

    private IEnumerable<T> DFS(Tree<T> tree, List<T> result)
    {
        foreach (var child in tree.Children)
        {
            child.DFS(child, result);
        }

        result.Add(tree.Value);

        return result;
    }

    public IEnumerable<T> OrderBFS()
    {
        var queue = new Queue<Tree<T>>();
        queue.Enqueue(this);

        var result = new List<T>();

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            result.Add(current.Value);

            foreach (var child in current.Children)
            {
                queue.Enqueue(child);
            }
        }

        return result;
    }
}
