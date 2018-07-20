﻿public class Box<T>
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