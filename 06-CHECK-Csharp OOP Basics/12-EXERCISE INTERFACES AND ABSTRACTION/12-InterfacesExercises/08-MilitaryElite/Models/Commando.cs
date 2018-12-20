using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ISoldier, IPrivate, ISpecialisedSoldier, ICommando
{
    public List<Mission> MissionList { get;protected set; }

    public Commando(string firstName, string lastName, string id, decimal salary, string corps) : base(firstName, lastName, id, salary, corps)
    {
        MissionList = new List<Mission>();
    }

    public void AddMission(Mission currentMission)
    {
        MissionList.Add(currentMission);
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
        sb.AppendLine($"Corps: {Corps}");
        sb.AppendLine($"Missions:");
        foreach (var mission in MissionList)
        {
            sb.AppendLine($"  {mission.ToString()}");
        }
        var result = sb.ToString().TrimEnd();
        return  result;
    }
}