public abstract class Soldier : ISoldier
{
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public string Id { get;protected set; }

    public Soldier(string firstName,string lastName,string id)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
    }
}