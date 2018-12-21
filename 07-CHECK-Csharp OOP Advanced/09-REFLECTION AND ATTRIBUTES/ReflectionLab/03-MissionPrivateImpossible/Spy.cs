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

    public string AnalyzeAcessModifiers(string classToInvestigate)
    {
        var sb = new StringBuilder();

        var type = Type.GetType(classToInvestigate);
        var publicFields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        var privateGetters = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic).Where(g=>g.Name.StartsWith("get")).ToArray();
        var publicSetters = type.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(g => g.Name.StartsWith("set")).ToArray();

        foreach (var field in publicFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (var getter in privateGetters)
        {
            sb.AppendLine($"{getter.Name} have to be public!");
        }
        foreach (var setter in publicSetters)
        {
            sb.AppendLine($"{setter.Name} have to be private!");
        }
        var result = sb.ToString().Trim();
        return result;
    }

    public string RevealPrivateMethods(string classToInvestigate)
    {
        var sb = new StringBuilder();
        var type = Type.GetType(classToInvestigate);
        sb.AppendLine($"All Private Methods of Class: {classToInvestigate}");
        sb.AppendLine($"Base Class: {type.BaseType.Name}");
        var privateMetods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var method in privateMetods)
        {
            sb.AppendLine($"{method.Name}");
        }

        var result = sb.ToString().Trim();
        return result;
    }
}
