public class Pokemon
{
    public string Name { get; set; }
    public string Element { get; set; }
    public int Health { get; set; }

    public Pokemon(string input)
    {
        var args = input.Split();
        Name = args[1];
        Element = args[2];
        Health = int.Parse(args[3]);
    }
}