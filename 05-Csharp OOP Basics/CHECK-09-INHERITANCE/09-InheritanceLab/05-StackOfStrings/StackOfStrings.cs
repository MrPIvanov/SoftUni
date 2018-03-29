using System.Collections.Generic;

public class StackOfStrings
{
    List<string> data = new List<string>();

    public void Push(string item)
    {
        data.Add(item);
    }

    public string Pop()
    {
        string result = "";
        result = data[data.Count - 1];
        data.RemoveAt(data.Count-1);

        return result;
    }

    public string Peek()
    {
        string result = "";
        result = data[data.Count - 1];

        return result;
    }

    public bool IsEmpty()
    {
        if (data.Count==0)
        {
            return true;
        }
        return false;
    }
}