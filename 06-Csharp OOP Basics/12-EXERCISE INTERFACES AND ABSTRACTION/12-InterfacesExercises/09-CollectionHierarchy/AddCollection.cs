using System.Collections.Generic;

public class AddCollection : IAdd
{
    private List<string> collection;

    private List<string> Collection
    {
        get { return collection; }
        set { collection = value; }
    }
    public AddCollection()
    {
        Collection = new List<string>();
    }

    public int Add(string item)
    {
        Collection.Insert(Collection.Count, item);
        return Collection.Count - 1;
    }
}