using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private List<BankAccount> accounts;

    public List<BankAccount> Accounts
    {
        get { return accounts; }
        set { accounts = value; }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Accounts = new List<BankAccount>();

    }

    public Person(string name, int age, List<BankAccount> accounts) :this(name, age)
    {
        Accounts.AddRange(accounts);
    }

    public decimal GetBalance()
    {
        return Accounts.Sum(a => a.Balance);
    }


}


