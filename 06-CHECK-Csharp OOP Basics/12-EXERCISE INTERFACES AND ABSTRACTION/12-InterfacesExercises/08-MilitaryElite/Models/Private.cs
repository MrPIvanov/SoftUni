using System.Text;

public class Private : Soldier, ISoldier, IPrivate
{
    public decimal Salary { get; protected set; }

    public Private(string firstName, string lastName, string id,decimal salary) : base(firstName, lastName, id)
    {
        Salary = salary;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");

        var result = sb.ToString().TrimEnd();
        return result;
    }
}