using System.Collections.Generic;
using System.Linq;

public class Family
{
    public List<Person> AllPeople { get; set; }

    public Family()
    {
        AllPeople = new List<Person>();
    }

    public void AddMember(Person person)
    {
        AllPeople.Add(person);
    }

    public Person GetOldestMember()
    {
        return AllPeople.OrderByDescending(x => x.Age).FirstOrDefault();
    }
}