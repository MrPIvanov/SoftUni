using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ISoldier, IPrivate, ILeutenantGeneral
{
    public List<Private> PrivatesList { get; protected  set; }

    public LeutenantGeneral(string firstName, string lastName, string id, decimal salary) : base(firstName, lastName, id, salary)
    {
        PrivatesList = new List<Private>();
    }

    public void AddPrivate(Private currentPrivate)
    {
        PrivatesList.Add(currentPrivate);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
        sb.AppendLine($"Privates:");
        foreach (var privat in PrivatesList)
        {
            sb.AppendLine($"  {privat.ToString()}");
        }

        var result = sb.ToString().TrimEnd();
        return result;
    }
}