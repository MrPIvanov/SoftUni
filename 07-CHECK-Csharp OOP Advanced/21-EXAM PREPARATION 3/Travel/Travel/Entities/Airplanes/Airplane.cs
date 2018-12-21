using System;
using System.Collections.Generic;
using System.Linq;
using Travel.Entities.Airplanes.Contracts;
using Travel.Entities.Contracts;

namespace Travel.Entities.Airplanes
{
    public abstract class Airplane : IAirplane
    {
        private readonly List<IBag> baggageCompartment;
        private readonly List<IPassenger> passengers;

        protected Airplane(int seats, int baggageCompartments)
        {
            this.passengers = new List<IPassenger>();
            this.baggageCompartment = new List<IBag>();

            this.Seats = seats;
            this.BaggageCompartments = baggageCompartments;
        }

        public int Seats { get; private set; }

        public int BaggageCompartments { get; private set; }

        public IReadOnlyCollection<IBag> BaggageCompartment => this.baggageCompartment.AsReadOnly();

        public IReadOnlyCollection<IPassenger> Passengers => this.passengers.AsReadOnly();

        public bool IsOverbooked => this.Passengers.Count > this.Seats;

        public void AddPassenger(IPassenger passenger)
        {
            this.passengers.Add(passenger);
        }

        public IEnumerable<IBag> EjectPassengerBags(IPassenger passenger)
        {
            var bags = this.baggageCompartment.Where(x => x.Owner == passenger).ToList();

            foreach (var bag in bags)
            {
                this.baggageCompartment.Remove(bag);
            }
            return bags;
        }

        public void LoadBag(IBag bag)
        {
            if (this.BaggageCompartments <= this.BaggageCompartment.Count)
            {
                throw new InvalidOperationException($"No more bag room in {this.GetType().Name}!");
            }

            this.baggageCompartment.Add(bag);
        }

        public IPassenger RemovePassenger(int seat)
        {
            var passanger = this.passengers[seat];
            this.passengers.RemoveAt(seat);

            return passanger;
        }
    }
}