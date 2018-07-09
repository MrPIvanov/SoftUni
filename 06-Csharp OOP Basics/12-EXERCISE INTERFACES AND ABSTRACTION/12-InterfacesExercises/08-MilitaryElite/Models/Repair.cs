using System.Text;

public class Repair
{
    public string Name { get; set; }
    public int HoursWorked { get; set; }

    public Repair(string name, int hoursWorked)
    {
        Name = name;
        HoursWorked = hoursWorked;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Part Name: {Name} Hours Worked: {HoursWorked}");
        var result = sb.ToString().TrimEnd();
        return result;
    }
}