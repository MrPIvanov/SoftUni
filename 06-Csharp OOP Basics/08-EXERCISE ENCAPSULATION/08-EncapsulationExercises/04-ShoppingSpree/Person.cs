using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    public List<string> ProductsBouth { get; set; }

    public string Name
    {
        get { return name; }
        set { name = value;}
    }

    public decimal Money
    {
        get { return money; }
        set { money = value; }
    }

    public Person(string name, decimal money)
    {
        ProductsBouth = new List<string>();
        Name = name;
        Money = money;
    }
}