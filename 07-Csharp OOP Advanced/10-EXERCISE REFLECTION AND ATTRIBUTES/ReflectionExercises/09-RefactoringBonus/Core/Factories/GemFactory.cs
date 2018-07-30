using System;
using System.Linq;
using System.Reflection;

public class GemFactory : IGemFactory
{
    public IGem CreateGem(string[] data)
    {
        var possition = int.Parse(data[1]);
        var input = data[2];
        var args = input.Split();
        var rarity = args[0];
        var gemType = args[1];

        var assembly = Assembly.GetExecutingAssembly();
        var models = assembly.GetTypes();
        var type = models.Where(g => g.Name == gemType).FirstOrDefault();

        if (type==null)
        {
            throw new ArgumentException("Invalid Type!");
        }
        if (!typeof(IGem).IsAssignableFrom(type))
        {
            throw new ArgumentException("Invalid GemType!");
        }

        var instanceParams = new object[] {rarity,possition };
        var instance = (IGem)Activator.CreateInstance(type, instanceParams);

        return instance;

    }
}