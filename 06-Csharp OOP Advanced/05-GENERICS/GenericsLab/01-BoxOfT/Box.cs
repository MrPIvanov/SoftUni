using System.Collections.Generic;

public class Box<T>
{
    public List<T> Items { get; set; }

    public int Count => this.Items.Count;

    public Box()
    {
        this.Items = new List<T>();
    }

    public void Add(T item)
    {
        this.Items.Add(item);
    }

    public T Remove()
    {
        var element = this.Items[this.Items.Count-1];
        this.Items.RemoveAt(this.Items.Count - 1);
        return element;
    }

}