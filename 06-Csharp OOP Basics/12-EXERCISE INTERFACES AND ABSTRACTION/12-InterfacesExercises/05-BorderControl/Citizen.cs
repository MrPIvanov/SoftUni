public abstract class Citizen
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }

    public Citizen(string name, string id)
    {
        Name = name;
        Id = id;
    }
}