public class Human : Citizen
{
    public Human(string name, string id, int age) : base(name, id)
    {
        Age = age;
    }
}