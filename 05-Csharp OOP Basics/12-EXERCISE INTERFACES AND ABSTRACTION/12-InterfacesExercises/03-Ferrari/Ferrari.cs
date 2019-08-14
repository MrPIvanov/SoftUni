public class Ferrari : ICarMove
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Model { get; set; }

    public Ferrari(string name)
    {
        Name = name;
        Model = "488-Spider";
    }
    public string Start()
    {
        return "Zadu6avam sA!";
    }

    public string Stop()
    {
        return "Brakes!";
    }
}