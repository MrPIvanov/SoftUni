using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string classToInvestigate, params string[] fieldsToInvestigate)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {classToInvestigate}");

        var type = Type.GetType(classToInvestigate);
        var classInstance = Activator.CreateInstance(type, new object[] { });
        var classFields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

        foreach (var field in classFields.Where(f => fieldsToInvestigate.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        var result = sb.ToString().Trim();
        return result;
    }
}