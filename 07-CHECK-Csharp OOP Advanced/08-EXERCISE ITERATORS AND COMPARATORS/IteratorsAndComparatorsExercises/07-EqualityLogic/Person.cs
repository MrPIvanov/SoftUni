using System;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name,int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override bool Equals(object obj)
    {
        var item = obj as Person;

        return this.Name == item.Name && this.Age == item.Age;
    }

    public override int GetHashCode()
    {
        return this.Name.GetHashCode() + this.Age.GetHashCode();
    }

    public int CompareTo(Person other)
    {
        var result = this.Name.CompareTo(other.Name);
        if (result==0)
        {
            result = this.Age.CompareTo(other.Age);
        }
        return result;
    }
}