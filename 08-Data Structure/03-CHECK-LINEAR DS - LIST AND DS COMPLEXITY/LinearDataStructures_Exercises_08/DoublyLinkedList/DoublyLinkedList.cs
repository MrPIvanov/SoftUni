using System;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private class ListNode<T>
    {
        public T Value { get; private set; }

        public ListNode<T> NextNode { get; set; }

        public ListNode<T> PrevNode { get; set; }

        public ListNode(T value)
        {
            this.Value = value;
        }
    }

    private ListNode<T> head;
    private ListNode<T> tail;

    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        if (this.Count == 0)
        {
            this.head = this.tail = new ListNode<T>(element);
        }
        else
        {
            var newHead = new ListNode<T>(element);
            newHead.NextNode = this.head;
            this.head.PrevNode = newHead;
            this.head = newHead;
        }
        this.Count++;
    }

    public void AddLast(T element)
    {
        if (this.Count == 0)
        {
            this.head = this.tail = new ListNode<T>(element);
        }
        else
        {
            var newNode = new ListNode<T>(element);
            newNode.PrevNode = this.tail;
            this.tail.NextNode = newNode;
            this.tail = newNode;
        }
        this.Count++;
    }

    public T RemoveFirst()
    {
        var item = default(T);

        if (this.Count == 0)
        {
            throw new InvalidOperationException("List Empty");
        }

        else if (this.Count == 1)
        {
            item = this.head.Value;
            this.head = this.tail = null;
        }

        else
        {
            item = this.head.Value;

            this.head = this.head.NextNode;
            this.head.PrevNode = null;
        }
        this.Count--;
        return item;
    }

    public T RemoveLast()
    {
        var item = default(T);

        if (this.Count == 0)
        {
            throw new InvalidOperationException("List Empty");
        }

        else if (this.Count == 1)
        {
            item = this.tail.Value;

            this.tail = this.head = null;
        }

        else
        {
            item = this.tail.Value;

            this.tail = this.tail.PrevNode;
            this.tail.NextNode = null;
        }

        this.Count--;
        return item;
    }

    public void ForEach(Action<T> action)
    {
        var currentNode = this.head;
        while (currentNode != null)
        {
            action(currentNode.Value);
            currentNode = currentNode.NextNode;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        var currentNode = this.head;
        while (currentNode != null)
        {
            yield return currentNode.Value;
            currentNode = currentNode.NextNode;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public T[] ToArray()
    {
        var result = new T[this.Count];

        var currentNode = this.head;
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = currentNode.Value;
            currentNode = currentNode.NextNode;
        }

        return result;
    }
}


class Example
{
    static void Main()
    {
        var list = new DoublyLinkedList<int>();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.AddLast(5);
        list.AddFirst(3);
        list.AddFirst(2);
        list.AddLast(10);
        Console.WriteLine("Count = {0}", list.Count);

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveFirst();
        list.RemoveLast();
        list.RemoveFirst();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveLast();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");
    }
}
