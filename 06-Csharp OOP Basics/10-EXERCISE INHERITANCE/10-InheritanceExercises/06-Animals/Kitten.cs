public class Kitten : Cat, ISoundProducable
{
    private const string Gender = "Female";

    public Kitten(string name, int age, string gender) : base(name, age, Gender)
    {
    }

    public override string ProduceSound()
    {
        return "Meow";
    }
}