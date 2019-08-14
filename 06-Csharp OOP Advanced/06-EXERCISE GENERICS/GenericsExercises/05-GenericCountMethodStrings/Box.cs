using System;

public class Box<T> where T : IComparable<T>
{
    public T Item { get; set; }

    public Box(T item)
    {
        this.Item = item;
    }

    public override string ToString()
    {
        return $"{Item.GetType().FullName}: {this.Item}";
    }
}