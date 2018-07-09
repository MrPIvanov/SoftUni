using System.Collections.Generic;

public class AddRemoveCollection :IAdd, IRemove
{
    private List<string> collection;

    private List<string> Collection
    {
        get { return collection; }
        set { collection = value; }
    }

    public AddRemoveCollection()
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
        var itemToRemove = Collection[Collection.Count - 1];
        Collection.RemoveAt(Collection.Count-1);
        return itemToRemove;
    }
}