using System;

public class CircularQueue<T>
{
    private const int DefaultCapacity = 4;

    private T[] data;

    private int startIndex;

    private int endIndex;

    public int Count { get; private set; }

    public CircularQueue(int capacity = DefaultCapacity)
    {
        this.data = new T[capacity];
    }

    public void Enqueue(T element)
    {
        if (this.Count == this.data.Length)
        {
            this.Resize();
        }

        this.data[endIndex] = element;

        this.endIndex = (this.endIndex + 1) % this.data.Length;

        this.Count++;
    }

    private void Resize()
    {
        var newData = new T[this.data.Length * 2];

        for (int i = 0; i < this.Count; i++)
        {
            newData[i] = this.data[this.startIndex];
            this.startIndex = (this.startIndex + 1) % this.data.Length;
        }

        this.data = newData;
        this.startIndex = 0;
        this.endIndex = this.Count;
    }

    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        var item = this.data[this.startIndex];

        this.startIndex = (this.startIndex + 1) % this.data.Length;

        this.Count--;

        return item;
    }

    public T[] ToArray()
    {
        var dataToReturn = new T[this.Count];

        for (int i = 0; i < this.Count; i++)
        {
            dataToReturn[i] = this.data[this.startIndex];
            this.startIndex = (this.startIndex + 1) % this.data.Length;
        }

       return dataToReturn;
    }
}


public class Example
{
    public static void Main()
    {

        CircularQueue<int> queue = new CircularQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        int first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-7);
        queue.Enqueue(-8);
        queue.Enqueue(-9);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");
    }
}
