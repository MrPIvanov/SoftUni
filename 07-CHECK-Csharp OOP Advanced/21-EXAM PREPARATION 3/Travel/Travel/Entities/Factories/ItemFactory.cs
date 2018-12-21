using System;
using System.Linq;
using System.Reflection;
using Travel.Entities.Factories.Contracts;
using Travel.Entities.Items.Contracts;

namespace Travel.Entities.Factories
{
    public class ItemFactory : IItemFactory
    {
        public IItem CreateItem(string type)
        {
            var itemType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == type);

            var item = (IItem)Activator.CreateInstance(itemType);

            return item;
        }
    }
}
