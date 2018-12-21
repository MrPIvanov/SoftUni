using System;
using System.Linq;
using System.Reflection;

public class WeaponFactory : IWeaponFactory
{
    public IWeapon CreateWeapon(string[] data)
    {
        var weaponName = data[1];

        var weaponType = data[0];
        var args = weaponType.Split();
        var rarity = args[0];
        var weaponSort = args[1];

        var assembly = Assembly.GetExecutingAssembly();
        var models = assembly.GetTypes();
        var type = models.Where(t => t.Name == weaponSort).FirstOrDefault();

        if (type==null)
        {
            throw new ArgumentException("Invalid Type!");
        }
        if (!typeof(IWeapon).IsAssignableFrom(type))
        {
            throw new ArgumentException("Invalid WeaponType!");
        }


        var instanceParams = new object[] {rarity, weaponName };
        var instance = (IWeapon)Activator.CreateInstance(type,instanceParams);

        return instance;
    }
}