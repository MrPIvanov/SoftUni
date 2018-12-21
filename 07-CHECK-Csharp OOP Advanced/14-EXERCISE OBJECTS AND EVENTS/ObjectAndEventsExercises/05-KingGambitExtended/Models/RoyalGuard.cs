public class RoyalGuard : Subordinate
{
    public RoyalGuard(string name) : base(name, 3)
    {
    }

    public override void ReactToAtack()
    {
        System.Console.WriteLine($"Royal Guard {this.Name} is defending!");
    }
}