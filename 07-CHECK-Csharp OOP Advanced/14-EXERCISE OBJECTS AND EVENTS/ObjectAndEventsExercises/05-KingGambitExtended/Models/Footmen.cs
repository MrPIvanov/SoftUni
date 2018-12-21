public class Footmen : Subordinate
{
    public Footmen(string name) : base(name, 2)
    {
    }

    public override void ReactToAtack()
    {
        System.Console.WriteLine($"Footman {this.Name} is panicking!");
    }
}