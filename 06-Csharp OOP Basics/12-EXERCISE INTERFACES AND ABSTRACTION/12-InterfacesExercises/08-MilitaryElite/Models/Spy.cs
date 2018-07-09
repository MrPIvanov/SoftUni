using System.Text;

public class Spy : Soldier, ISoldier, ISpy
{
    public int CodeNumber { get; protected set; }

    public Spy(string firstName, string lastName, string id,int codeNumber) : base(firstName, lastName, id)
    {
        CodeNumber = codeNumber;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
        sb.AppendLine($"Code Number: {CodeNumber}");

        var result = sb.ToString().TrimEnd();
        return result;
    }
}