namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using System.Reflection;
    using System.Linq;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var model = assembly.GetTypes().FirstOrDefault(t=>t.Name==unitType);

            if (model==null)
            {
                throw new ArgumentException("Invalid command!");
            }
            if (!typeof(IUnit).IsAssignableFrom(model))
            {
                throw new ArgumentException("Invalid IUnit");
            }

            var unit = (IUnit)Activator.CreateInstance(model);
            return unit;

        }
    }
}
