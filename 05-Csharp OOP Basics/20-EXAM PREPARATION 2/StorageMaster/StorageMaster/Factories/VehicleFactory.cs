﻿using StorageMaster.Models.Vehicles;
using System;

namespace StorageMaster.Factories
{
    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string type)
        {
            Vehicle vehicle = null;

            switch (type)
            {
                case "Van":
                    vehicle = new Van();
                    break;

                case "Semi":
                    vehicle = new Semi();
                    break;

                case "Truck":
                    vehicle = new Truck();
                    break;

                default:
                    throw new InvalidOperationException("Invalid vehicle type!");
            }
            return vehicle;
        }
    }
}
