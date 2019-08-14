public abstract class LiveCreature
{
    public string Name { get; set; }
    public string Birthdate { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }

    public LiveCreature(string name, string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }

}