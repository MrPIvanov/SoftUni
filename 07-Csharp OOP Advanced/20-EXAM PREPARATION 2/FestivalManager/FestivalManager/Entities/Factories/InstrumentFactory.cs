using FestivalManager.Entities.Contracts;
using FestivalManager.Entities.Factories.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace FestivalManager.Entities.Factories
{
    public class InstrumentFactory : IInstrumentFactory
    {
        public IInstrument CreateInstrument(string type)
        {
            var typeOfClass = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == type);

            var instance = (IInstrument)Activator.CreateInstance(typeOfClass);

            return instance;
        }
    }
}
