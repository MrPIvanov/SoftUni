using System;
using System.Linq;
using System.Reflection;
using Travel.Entities.Airplanes.Contracts;
using Travel.Entities.Factories.Contracts;

namespace Travel.Entities.Factories
{
    public class AirplaneFactory : IAirplaneFactory
    {
        public IAirplane CreateAirplane(string type)
        {
            var planeType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == type);

            var plane =  (IAirplane)Activator.CreateInstance(planeType);

            return plane;
        }
    }
}