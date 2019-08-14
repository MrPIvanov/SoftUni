using System;
using System.Collections;
using System.Collections.Generic;

public class CustomLinkedList<T> : IEnumerable<T>
{
    public class Node
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public Node Next { get; set; }
    }


    public CustomLinkedList()
    {
        this.Count = 0;
    }

    public int Count { get; private set; }
    public Node Head { get; private set; }
    public Node Tail { get; private set; }

    public void Add(T value)
    {
        Node old = this.Tail;
        this.Tail = new Node(value);

        if (this.IsEmpty())
        {
            this.Head = this.Tail;
        }
        else
        {
            old.Next = this.Tail;
        }

        this.Count++;
    }

    public void Remove(T value)
    {
        if (this.IsEmpty())
        {
            throw new InvalidOperationException("List is Empty!");
        }

        Node current = this.Head;
        Node old = this.Head;

        for (int i = 0; i < this.Count; i++)
        {
            if (current.Value.Equals(value))
            {
                if (i==0)
                {
                    this.Head = this.Head.Next;
                }
                old.Next = current.Next;
                this.Count--;
                return;
            }
            else
            {
                old = current;
                current = current.Next;
            }

        }




    }

    private bool IsEmpty()
    {
        if (this.Count == 0)
        {
            return true;
        }
        return false;
    }


    public IEnumerator<T> GetEnumerator()
    {
        Node current = this.Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}