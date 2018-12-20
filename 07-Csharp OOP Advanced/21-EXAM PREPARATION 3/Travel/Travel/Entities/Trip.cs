﻿using Travel.Entities.Airplanes.Contracts;
using Travel.Entities.Contracts;

namespace Travel.Entities
{
	public class Trip : ITrip
	{
		private static int id = 1;

		public Trip(string source, string destination, IAirplane airplane)
		{
			this.Source = source;
			this.Destination = destination;
			this.Airplane = airplane;

			this.Id = GenerateId(source, destination);
		}

		public string Id { get; private set; }

		public string Source { get; private set; }

		public string Destination { get; private set; }

		public bool IsCompleted { get; private set; }

		public IAirplane Airplane { get; private set; }

		public void Complete() => this.IsCompleted = true;

		private static string GenerateId(string departure, string destination)
		{
			return $"{departure}{destination}{id++}";
		}
	}
}