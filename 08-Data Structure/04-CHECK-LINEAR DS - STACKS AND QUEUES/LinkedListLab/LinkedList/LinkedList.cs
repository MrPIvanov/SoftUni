using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    public class Node
    {
        public T Value { get; set; }

        public Node Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }

    public Node Head { get; set; }

    public Node Tail { get; set; }

    public int Count { get; private set; }

    public void AddFirst(T item)
    {
        var itemToAdd = new Node(item);

        if (this.Count == 0)
        {
            this.Head = itemToAdd;
            this.Tail = itemToAdd;
        }
        else if (this.Count == 1)
        {
            this.Head = itemToAdd;
            this.Head.Next = this.Tail;
        }
        else
        {
            var oldHead = this.Head;
            this.Head = itemToAdd;
            this.Head.Next = oldHead;
        }

        this.Count++;
    }

    public void AddLast(T item)
    {
        var itemToAdd = new Node(item);

        if (this.Count == 0)
        {
            this.Head = itemToAdd;
            this.Tail = itemToAdd;
        }
        else if (this.Count == 1)
        {
            this.Tail = itemToAdd;
            this.Head.Next = this.Tail;
        }
        else
        {
            var oldTail = this.Tail;
            this.Tail = itemToAdd;
            oldTail.Next = this.Tail;
        }
        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        var itemToReturn = this.Head.Value;

        if (this.Count == 1)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            this.Head = this.Head.Next;
        }

        this.Count--;

        return itemToReturn;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        var itemToReturn = this.Tail.Value;

        if (this.Count == 1)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            var currentNode = this.Head;
            while (true)
            {
                if (currentNode.Next == this.Tail)
                {
                    this.Tail = currentNode;
                    break;
                }
                currentNode = currentNode.Next;
            }
        }

        this.Count--;

        return itemToReturn;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var currentNode = this.Head;
        while (currentNode != null)
        {
            yield return currentNode.Value;
            currentNode = currentNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
