using System;

public class LinkedStack<T>
{
    public class Node
    {
        public T Value;

        public Node PrevNode;

        public Node(T value)
        {
            this.Value = value;
        }
    }

    public int Count { get; private set; }

    public Node CurrentNode { get; private set; }

    public void Push(T item)
    {
        var node = new Node(item);

        if (this.Count == 0)
        {
            this.CurrentNode = node;
        }
        else
        {
            node.PrevNode = this.CurrentNode;
            this.CurrentNode = node;
        }

        this.Count++;
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        var item = this.CurrentNode.Value;

        this.CurrentNode = this.CurrentNode.PrevNode;

        this.Count--;
        return item;
    }

    public T[] ToArray()
    {
        var array = new T[this.Count];


        var nodeToAdd = this.CurrentNode;
        for (int i = 0; i < this.Count; i++)
        {
            array[i] = nodeToAdd.Value;
            nodeToAdd = nodeToAdd.PrevNode;
        }

        return array;
    }

}