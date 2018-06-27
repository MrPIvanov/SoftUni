public class StreetExtraordinaire : Cat
{
    public double DecibelsOfMeows { get; set; }

    public StreetExtraordinaire(string name, double decibels):base(name)
    {
        DecibelsOfMeows = decibels;
    }

    public override string ToString()
    {
        return $"StreetExtraordinaire {Name} {DecibelsOfMeows}";
    }
}