using System.Text;

public class Mission
{
    public string Name { get; set; }
    public string State { get; set; }

    public Mission(string name,string state)
    {
        Name = name;
        State = state;
    }   

    public void CompleteMission(Mission currentMission)
    {
        currentMission.State = "Finished";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Code Name: {Name} State: {State}");
       
        var result = sb.ToString().TrimEnd();
        return result;
    }
}