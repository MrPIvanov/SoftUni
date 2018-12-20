using System;
using System.Collections.Generic;

public class RandomList:List<string>
{
    Random random = new Random();

    public string RandomString()
    {
        string result=string.Empty;
        var list = new List<string>();
        var index = random.Next(0, list.Count-1);
        result = list[index];
        list.RemoveAt(index);

        return result;
    }
}