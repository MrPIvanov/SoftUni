﻿public class Citizen : IPerson,IBirthable,IIdentifiable
{
    private string name;
    private int age;
    private string id;
    private string birthdate;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Birthdate
    {
        get { return birthdate; }
        set { birthdate = value; }
    }


    public Citizen(string name, int age,string id,string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

}