using System.Collections.Generic;
using System.Text;

public class PersonInfo
{
    public string Name { get; set; }
    public Company Company { get; set; }
    public Car Car { get; set; }
    public List<Pokemon> Pokemons { get; set; }
    public List<Parent> Parents { get; set; }
    public List<Children> Childrens { get; set; }

    public PersonInfo(string name)
    {
        Name = name;
        Pokemons = new List<Pokemon>();
        Parents = new List<Parent>();
        Childrens = new List<Children>();

    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(Name);
        sb.AppendLine("Company:");
        sb.Append(Company == null ?  "" : $"{Company.Name} {Company.Department} {Company.Salary:f2}{System.Environment.NewLine}");
        sb.AppendLine("Car:");
        sb.Append(Car == null ? "" : $"{Car.Model} {Car.Speed}{System.Environment.NewLine}");
        sb.AppendLine("Pokemon:");
        if (Pokemons.Count!=0)
        {
            foreach (var poke in Pokemons)
            {
                sb.Append($"{poke.Name} {poke.Type}{System.Environment.NewLine}");

            }
        }
        sb.AppendLine("Parents:");
        if (Parents.Count != 0)
        {
            foreach (var parent in Parents)
            {
                sb.Append($"{parent.Name} {parent.BirthDay}{System.Environment.NewLine}");

            }
        }
        sb.AppendLine("Children:");
        if (Childrens.Count != 0)
        {
            foreach (var child in Childrens)
            {
                sb.Append($"{child.Name} {child.BirthDay}{System.Environment.NewLine}");

            }
        }




        var result = sb.ToString();
        return result;
    }
}