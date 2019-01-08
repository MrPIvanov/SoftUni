using System;
using System.Linq;

public class ArrayStack<T>
{
    private const int InitialCapacity = 16;

    private T[] data;

    public int Count { get; private set; }

    public ArrayStack(int capacity = InitialCapacity)
    {
        this.data = new T[capacity];
    }


    public void Push(T element)
    {
        if (this.Count == this.data.Length)
        {
            this.Grow();
        }

        this.data[this.Count++] = element;
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        return this.data[--this.Count];
    }

    public T[] ToArray()
    {
        var array = new T[this.Count];

        Array.Copy(this.data.Reverse().Skip(this.data.Length - this.Count).ToArray(), array, this.Count);

        return array;
    }

    private void Grow()
    {
        var newData = new T[this.data.Length * 2];

        Array.Copy(this.data, newData, this.Count);

        this.data = newData;
    }
}
