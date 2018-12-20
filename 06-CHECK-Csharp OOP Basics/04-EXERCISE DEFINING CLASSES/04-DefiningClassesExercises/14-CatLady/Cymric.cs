public class Cymric : Cat
{
    public double FurLength { get; set; }

    public Cymric(string name, double furLenght):base(name)
    {
        FurLength = furLenght;
    }

    public override string ToString()
    {
        return $"Cymric {Name} {FurLength:f2}";
    }
}