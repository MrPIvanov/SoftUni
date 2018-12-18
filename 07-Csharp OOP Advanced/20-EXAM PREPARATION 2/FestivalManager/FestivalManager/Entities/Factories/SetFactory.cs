using FestivalManager.Entities.Contracts;
using FestivalManager.Entities.Factories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FestivalManager.Entities.Factories
{
    public class SetFactory : ISetFactory
    {
        public ISet CreateSet(string name, string type)
        {
            var typeOfClass = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == type);

            var instance = (ISet)Activator.CreateInstance(typeOfClass, name);

            return instance;
        }
    }
}
