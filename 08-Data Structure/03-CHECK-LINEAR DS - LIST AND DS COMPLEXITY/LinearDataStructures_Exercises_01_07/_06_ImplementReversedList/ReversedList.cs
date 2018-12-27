using System;
using System.Collections;
using System.Collections.Generic;

public class ReversedList<T> : IEnumerable
{
    private T[] data;

    public ReversedList()
    {
        this.data = new T[2];
        this.Count = 0;
        this.Capacity = 2;
    }

    public int Count { get; private set; }

    public int Capacity { get; private set; }

    public void Add(T item)
    {
        if (this.Count == this.Capacity)
        {
            this.Grow();
        }

        this.data[this.Count] = item;
        this.Count++;
    }

    private void Grow()
    {
        var newData = new T[this.Capacity * 2];
        Array.Copy(this.data, newData, this.Count);
        this.data = newData;
        this.Capacity *= 2;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            return this.data[Math.Abs(index - this.Count) - 1];
        }

        set
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            this.data[Math.Abs(index - this.Count) - 1] = value;
        }
    }

    public T RemoveAt(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new IndexOutOfRangeException();
        }

        var item = this.data[index];

        for (int i = Math.Abs(index - this.Count) - 1; i < this.Capacity - 1; i++)
        {
            this.data[i] = this.data[i + 1];
        }

        this.Count--;

        return item;
    }

    public IEnumerator GetEnumerator()
    {
        var list = new List<T>();
        for (int i = this.Count - 1; i >= 0  ; i--)
        {
           list.Add(this.data[i]);
        }

        return list.GetEnumerator();
    }
}
