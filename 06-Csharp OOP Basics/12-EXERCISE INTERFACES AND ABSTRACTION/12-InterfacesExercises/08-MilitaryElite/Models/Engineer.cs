using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, ISoldier, IPrivate, ISpecialisedSoldier, IEngineer
{
    public List<Repair> RepairList { get;protected set; }

    public Engineer(string firstName, string lastName, string id, decimal salary, string corps) : base(firstName, lastName, id, salary, corps)
    {
        RepairList = new List<Repair>();
    }

    public void AddRepair(Repair currentRepair)
    {
        RepairList.Add(currentRepair);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
        sb.AppendLine($"Corps: {Corps}");
        sb.AppendLine($"Repairs:");
        foreach (var repair in RepairList)
        {
            sb.AppendLine($"  {repair.ToString()}");
        }
        var result = sb.ToString().TrimEnd();
        return result;
    }
}