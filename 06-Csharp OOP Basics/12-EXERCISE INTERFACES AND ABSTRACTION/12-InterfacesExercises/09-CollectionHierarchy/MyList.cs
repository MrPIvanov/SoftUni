using System.Collections.Generic;

public class MyList : IAdd,IRemove,IUsed
{
    private List<string> collection;

    private List<string> Collection
    {
        get { return collection; }
        set { collection = value; }
    }

    public MyList()
    {
        Collection = new List<string>();
    }

    public int Add(string item)
    {
        Collection.Insert(0, item);
        return 0;
    }

    public string Remove()
    {
        var itemToRemove = Collection[0];
        Collection.RemoveAt(0);
        return itemToRemove;
    }

    public int NumberOfElements()
    {
        return Collection.Count;
    }
}