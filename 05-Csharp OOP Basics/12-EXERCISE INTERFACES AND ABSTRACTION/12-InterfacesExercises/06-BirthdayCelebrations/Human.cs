public class Human : LiveCreature
{
    public Human(string name, string birthdate, int age, string id) : base(name, birthdate)
    {
        Age = age;
        Id = id;
    }
}