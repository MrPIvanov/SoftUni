using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        var addCollection = new AddCollection();
        var addCollectionAddResult = new List<int>();

        var addRemoveCollection = new AddRemoveCollection();
        var addRemoveCollectionAddResult = new List<int>();
        var addRemoveCollectionRemoveResult = new List<string>();

        var myList = new MyList();
        var myListAddResult = new List<int>();
        var myListRemoveResult = new List<string>();

        var allItemsToAdd = Console.ReadLine().Split();

        foreach (var item in allItemsToAdd)
        {
            addCollectionAddResult.Add(addCollection.Add(item));
            addRemoveCollectionAddResult.Add(addRemoveCollection.Add(item));
            myListAddResult.Add(myList.Add(item));
        }

        var numberOfRemoves = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfRemoves; i++)
        {
            addRemoveCollectionRemoveResult.Add(addRemoveCollection.Remove());
            myListRemoveResult.Add(myList.Remove());
        }

        Console.WriteLine(String.Join(' ', addCollectionAddResult));
        Console.WriteLine(String.Join(' ', addRemoveCollectionAddResult));
        Console.WriteLine(String.Join(' ', myListAddResult));
        Console.WriteLine(String.Join(' ', addRemoveCollectionRemoveResult));
        Console.WriteLine(String.Join(' ', myListRemoveResult));

    }
}