using Travel.Core;
using Travel.Core.Contracts;
using Travel.Core.Controllers;
using Travel.Core.Controllers.Contracts;
using Travel.Core.IO;
using Travel.Core.IO.Contracts;
using Travel.Entities;
using Travel.Entities.Contracts;

namespace Travel
{
    public static class StartUp
	{
		public static void Main()
		{
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IAirport airport = new Airport();

            IAirportController airportController = new AirportController(airport);
            IFlightController flightController = new FlightController(airport);

            IEngine engine = new Engine(reader ,writer, airportController, flightController);

            engine.Run();
		}
	}
}