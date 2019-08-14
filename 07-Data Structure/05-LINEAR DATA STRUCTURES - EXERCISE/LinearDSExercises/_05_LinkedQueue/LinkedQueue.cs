using System;

public class LinkedQueue<T>
{
    private class QueueNode
    {
        public T Value { get; private set; }
        public QueueNode NextNode { get; set; }
        public QueueNode PrevNode { get; set; }

        public QueueNode(T value)
        {
            this.Value = value;
        }
    }

    private QueueNode Head;

    private QueueNode Tail;

    public int Count { get; private set; }

    public void Enqueue(T element)
    {
        var node = new QueueNode(element);

        if (this.Count == 0)
        {
            this.Head = node;
            this.Tail = node;
        }
        else
        {
            this.Tail.NextNode = node;
            node.PrevNode = this.Tail;
            this.Tail = node;
        }

        this.Count++;
    }

    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        var item = this.Head.Value;

        if (this.Count == 1)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            this.Head = this.Head.NextNode;
        }

        this.Count--;
        return item;
    }

    public T[] ToArray()
    {
        var array = new T[this.Count];

        var currentNode = this.Head;
        for (int i = 0; i < this.Count; i++)
        {
            array[i] = currentNode.Value;
            currentNode = currentNode.NextNode;
        }

        return array;
    }
}
