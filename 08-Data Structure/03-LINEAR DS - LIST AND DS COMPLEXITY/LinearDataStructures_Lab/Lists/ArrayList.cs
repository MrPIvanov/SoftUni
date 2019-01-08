using System;

public class ArrayList<T>
{
    private T[] data;

    public ArrayList()
    {
        this.data = new T[2];
        this.Count = 0;
    }

    public int Count { get; private set; }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            return this.data[index];
        }

        set
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.data[index] = value;
        }
    }

    public void Add(T item)
    {
        if (this.Count == this.data.Length)
        {
            this.Resize();
        }

        this.data[Count] = item;

        this.Count++;
    }

    private void Resize()
    {
        var newData = new T[this.data.Length * 2];

        Array.Copy(this.data, newData, Count);

        this.data = newData;
    }

    public T RemoveAt(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new ArgumentOutOfRangeException();
        }

        var item = this.data[index];

        for (int i = index; i < this.Count - 1; i++)
        {
            this.data[i] = this.data[i + 1];
        }

        this.data[Count -1] = default(T);

        this.Count--;

        if (this.Count <= this.data.Length / 4)
        {
            Shrink();
        }

        return item;
    }

    private void Shrink()
    {
        var newData = new T[this.data.Length / 2];

        Array.Copy(this.data, newData, Count);

        this.data = newData;
    }
}
