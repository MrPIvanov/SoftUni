using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class Hierarchy<T> : IHierarchy<T>
{
    private Node root;
    private Dictionary<T, Node> allNodes;

    public Hierarchy(T root)
    {
        this.root = new Node(root);
        this.allNodes = new Dictionary<T, Node>();
        allNodes.Add(root, this.root);
    }

    public int Count
    {
        get
        {
            return this.allNodes.Count;
        }
    }

    public void Add(T element, T child)
    {
        if (!this.allNodes.ContainsKey(element))
        {
            throw new ArgumentException();
        }

        if (this.allNodes.ContainsKey(child))
        {
            throw new ArgumentException();
        }

        var parrentNode = this.allNodes[element];
        var childNode = new Node(child, parrentNode);

        parrentNode.Childrens.Add(childNode);
        this.allNodes.Add(child, childNode);
    }

    public void Remove(T element)
    {
        if (!this.allNodes.ContainsKey(element))
        {
            throw new ArgumentException();
        }

        var nodeToRemove = this.allNodes[element];

        if (nodeToRemove.Parrent == null)
        {
            throw new InvalidOperationException();
        }

        var nodeParrent = nodeToRemove.Parrent;

        foreach (var child in nodeToRemove.Childrens)
        {
            child.Parrent = nodeParrent;
            nodeParrent.Childrens.Add(child);
        }

        nodeParrent.Childrens.Remove(nodeToRemove);
        this.allNodes.Remove(nodeToRemove.Value);
    }

    public IEnumerable<T> GetChildren(T item)
    {
        if (!this.allNodes.ContainsKey(item))
        {
            throw new ArgumentException();
        }

        var node = this.allNodes[item];

        var childrens = node.Childrens.Select(x => x.Value);

        return childrens;
    }

    public T GetParent(T item)
    {
        if (!this.allNodes.ContainsKey(item))
        {
            throw new ArgumentException();
        }

        var node = this.allNodes[item];

        if (node.Parrent == null)
        {
            return default(T);
        }

        return node.Parrent.Value;
    }

    public bool Contains(T value)
    {
        if (this.allNodes.ContainsKey(value))
        {
            return true;
        }
        return false;
    }

    public IEnumerable<T> GetCommonElements(Hierarchy<T> other)
    {
        var result = new List<T>();

        foreach (var value in this.allNodes.Keys)
        {
            if (other.Contains(value))
            {
                result.Add(value);
            }
        }

        return result;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var queue = new Queue<Node>();

        queue.Enqueue(this.root);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();

            foreach (var child in currentNode.Childrens)
            {
                queue.Enqueue(child);
            }

            yield return currentNode.Value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class Node
    {
        public T Value { get; set; }

        public Node Parrent { get; set; }

        public List<Node> Childrens { get; set; }

        public Node(T value, Node parrent = null)
        {
            this.Value = value;
            this.Parrent = parrent;
            this.Childrens = new List<Node>();
        }
    }
}
