using System.Collections.Generic;

public class Family
{
    public List<Person> AllPeople { get; set; }

    public Family()
    {
        AllPeople = new List<Person>();
    }

    public void AddPerson(Person person)
    {
        AllPeople.Add(person);
    }
}