using System.Collections;
using System.Collections.Generic;

public class CustomStack : IEnumerable<int>
{
    private int countOfItems;
    public List<int> Items { get; set; }

    public CustomStack()
    {
        this.countOfItems = 0;
        this.Items = new List<int>();
    }

    public void Push(int item)
    {
        this.Items.Add(item);
        this.countOfItems++;
    }

    public void Pop()
    {
        if (countOfItems==0)
        {
            System.Console.WriteLine("No elements");
        }
        else
        {
            this.Items.RemoveAt(this.countOfItems - 1);
            this.countOfItems--;
        }
    }



    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.Items.Count; i++)
        {
            yield return this.Items[this.countOfItems-1 - i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}