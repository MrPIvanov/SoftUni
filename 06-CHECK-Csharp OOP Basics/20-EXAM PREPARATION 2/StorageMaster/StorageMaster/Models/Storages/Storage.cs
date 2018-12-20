using StorageMaster.Models.Proucts;
using StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Models.Storages
{
    public  abstract class Storage
    {
        private Vehicle[] vehicles;

        private List<Product> products;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.vehicles = new Vehicle[this.GarageSlots];
            this.products = new List<Product>();

            var index = 0;
            foreach (var vehicle in vehicles)
            {
                this.vehicles[index++] = vehicle;
            }
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public bool IsFull => this.products.Sum(p => p.Weight) >= this.Capacity;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.vehicles);

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            var vehicle = this.vehicles[garageSlot];

            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            var vehicle = this.GetVehicle(garageSlot);

            var freeSlotIndex = Array.IndexOf(deliveryLocation.vehicles, null);

            if (freeSlotIndex == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            deliveryLocation.vehicles[freeSlotIndex] = vehicle;

            this.vehicles[garageSlot] = null;

            return freeSlotIndex;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            var vehicle = this.GetVehicle(garageSlot);

            var numberOfUnloadProducts = 0;

            while (vehicle.Trunk.Count != 0 && !this.IsFull)
            {
                var product = vehicle.Unload();

                this.products.Add(product);

                numberOfUnloadProducts++;
            }
            
            return numberOfUnloadProducts;
        }
    }
}
