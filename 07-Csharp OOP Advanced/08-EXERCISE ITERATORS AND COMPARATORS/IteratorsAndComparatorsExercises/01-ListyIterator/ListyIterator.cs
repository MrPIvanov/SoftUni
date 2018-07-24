using System.Collections.Generic;

public class ListyIterator
{
    public List<string> Items { get;private set; }

    private int index;

    public ListyIterator(params string[] items)
    {
        this.Items = new List<string>(items);
        this.index = 0;
    }

    public bool HasNext()
    {
        if (this.index + 1 == this.Items.Count)
        {
            return false;
        }
        return true;
    } 

    public bool Move()
    {
        if (this.HasNext())
        {
            this.index++;
            return true;
        }
        return false;
    }

    public void Print()
    {
        if (this.Items.Count == 0)
        {
            throw new System.InvalidOperationException("Invalid Operation!");
        }

        System.Console.WriteLine(this.Items[index]);
    }
}