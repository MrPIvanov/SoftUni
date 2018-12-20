public class Siamese : Cat
{
    public double EarSize { get; set; }

    public Siamese(string name, double earSize):base(name)
    {
        EarSize = earSize;
    }

    public override string ToString()
    {
        return $"Siamese {Name} {EarSize}";
    }
}