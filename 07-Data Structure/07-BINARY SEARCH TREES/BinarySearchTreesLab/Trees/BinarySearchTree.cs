using System;
using System.Collections;
using System.Collections.Generic;

public class BinarySearchTree<T> where T : IComparable<T>
{
    private Node root;

    public BinarySearchTree(T value)
    {
        this.root = new Node(value);
    }

    public BinarySearchTree()
    {
        this.root = null;
    }

    private BinarySearchTree(Node node)
    {
        this.CopyItems(node);
    }

    private void CopyItems(Node node)
    {
        if (node == null)
        {
            return;
        }

        this.Insert(node.Value);
        this.CopyItems(node.Left);
        this.CopyItems(node.Right);
    }

    public void Insert(T value)
    {
        this.root = this.Insert(this.root, value);
    }

    private Node Insert(Node node, T value)
    {
        if (node == null)
        {
            return new Node(value);
        }

        var compare = node.Value.CompareTo(value);

        if (compare > 0)
        {
            node.Left = this.Insert(node.Left, value);
        }

        else if (compare < 0)
        {
            node.Right = this.Insert(node.Right, value);
        }

        else
        {
            //Values are the same. Write your logic here.
        }

        return node;
    }

    public bool Contains(T value)
    {
        var result = false;

        this.Contains(this.root, value, ref result);

        return result;
    }

    private void Contains(Node node, T value, ref bool result)
    {
        if (node == null)
        {
            return;
        }

        var compare = node.Value.CompareTo(value);

        if (compare < 0)
        {
            this.Contains(node.Right, value, ref result);
        }
        else if (compare > 0)
        {
            this.Contains(node.Left, value, ref result);
        }
        else
        {
            result = true;
        }
    }

    public void DeleteMin()
    {
        if (this.root == null)
        {
            return;
        }

        this.root = this.DeleteMin(this.root);
    }

    private Node DeleteMin(Node node)
    {
        if (node.Left != null)
        {
            node.Left = this.DeleteMin(node.Left);
        }
        else
        {
            if (node.Right == null)
            {
                return null;
            }
            node = node.Right;
        }
        return node;
    }

    public BinarySearchTree<T> Search(T item)
    {
        Node current = this.root;

        while (current != null)
        {
            if (item.CompareTo(current.Value) > 0)
            {
                current = current.Right;
            }
            else if (item.CompareTo(current.Value) < 0)
            {
                current = current.Left;
            }
            else
            {
                break;
            }
        }

        if (current == null)
        {
            return null;
        }
        else
        {
            return new BinarySearchTree<T>(current);
        }
    }


    public IEnumerable<T> Range(T startRange, T endRange)
    {
        var result = new List<T>();

        this.root = this.Range(this.root, startRange, endRange, result);

        return result;
    }

    private Node Range(Node node, T start, T end, List<T> result)
    {
        if (node == null)
        {
            return node;
        }

        var compareLow = node.Value.CompareTo(start);
        var compareHigh = node.Value.CompareTo(end);

        if (compareLow > 0)
        {
            node.Left = this.Range(node.Left, start, end, result);
        }
        if (compareLow >= 0 && compareHigh <= 0)
        {
            result.Add(node.Value);
        }
        if (compareHigh < 0)
        {
            node.Right = this.Range(node.Right, start, end, result);
        }
        return node;
    }

    public void EachInOrder(Action<T> action)
    {
        this.EachInOrder(this.root, action);
    }

    private void EachInOrder(Node node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }

        this.EachInOrder(node.Left, action);
        action(node.Value);
        this.EachInOrder(node.Right, action);
    }

    private class Node
    {
        public T Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }
}

public class Launcher
{
    public static void Main(string[] args)
    {
        var bst = new BinarySearchTree<int>();

        bst.Insert(10);
        bst.Insert(20);
        bst.Insert(30);
        bst.Insert(25);
        bst.Insert(5);
        bst.Insert(8);

        var tree = bst.Search(30);

        tree.Insert(27);

        Console.WriteLine();
    }
}
