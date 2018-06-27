using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public string BirthDay { get; set; }
    public List<Person> Parents { get; set; }
    public List<Person> Childrens { get; set; }

    public Person(string name, string birthDay)
    {
        Name = name;
        BirthDay = birthDay;
        Parents = new List<Person>();
        Childrens = new List<Person>();
    }
}