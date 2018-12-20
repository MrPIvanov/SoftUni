﻿using System;
using System.Linq;
using Travel.Core.Contracts;
using Travel.Core.Controllers.Contracts;
using Travel.Core.IO.Contracts;

namespace Travel.Core
{
	public class Engine : IEngine
	{
		private readonly IReader reader;
		private readonly IWriter writer;

		private readonly IAirportController airportController;
		private readonly IFlightController flightController;

		public Engine(IReader reader,
                      IWriter writer,
                      IAirportController airportController,
			          IFlightController flightController)
		{
			this.reader = reader;
			this.writer = writer;
			this.airportController = airportController;
			this.flightController = flightController;
		}

		public void Run()
		{
			while (true)
			{
				var input = this.reader.ReadLine();

				if (input == "END")
				{
					break;
				}

				try
				{
					var result = this.ProcessCommand(input);
					Console.WriteLine(result);
				}
				catch (Exception ex)
				{
					Console.WriteLine("ERROR: " + ex.Message);
				}
			}
		}

		public string ProcessCommand(string input)
		{
			var tokens = input.Split();

			var command = tokens[0];
			var args = tokens.Skip(1).ToArray();

			switch (command)
			{
				case "RegisterPassenger":
				{
					var name = args[0];
					var output = this.airportController.RegisterPassenger(name);
					return output;
				}
				case "RegisterTrip":
				{
					var source = args[0];
					var destination = args[1];
					var planeType = args[2];

					var output = this.airportController.RegisterTrip(source, destination, planeType);
					return output;
				}
				case "RegisterBag":
				{
					var username = args[0];
					var bagItems = args.Skip(1).ToArray();

					var output = this.airportController.RegisterBag(username, bagItems);
					return output;
				}
				case "CheckIn":
				{
					var username = args[0];
					var tripId = args[1];
					var bagCheckInIndices = args.Skip(2).Select(int.Parse).ToArray();

					var output = this.airportController.CheckIn(username, tripId, bagCheckInIndices);
					return output;
				}
				case "TakeOff":
				{
					var output = this.flightController.TakeOff();
					return output;
				}
				default:
					throw new InvalidOperationException("Invalid command!");
			}
		}
    }
}