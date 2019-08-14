using System;
using System.Linq;

namespace StorageMaster.Core
{
    public class Engine
    {
        private bool IsRunning;

        private StorageMaster StorageMaster;

        public Engine(StorageMaster storageMaster)
        {
            this.StorageMaster = storageMaster;
            this.IsRunning = false;
        }

        public void Run()
        {
            this.IsRunning = true;

            while (this.IsRunning)
            {
                var tokens = Console.ReadLine().Split();

                var command = tokens[0];
                var result = "";
                var storageName = "";
                var garageSlots = 0;

                try
                {
                    switch (command)
                    {
                        case "AddProduct":
                            var productType = tokens[1];
                            var productPrice = double.Parse(tokens[2]);
                            result = this.StorageMaster.AddProduct(productType, productPrice);
                            break;

                        case "RegisterStorage":
                            var storageType = tokens[1];
                            storageName = tokens[2];
                            result = this.StorageMaster.RegisterStorage(storageType, storageName);
                            break;

                        case "SelectVehicle":
                            storageName = tokens[1];
                            garageSlots = int.Parse(tokens[2]);
                            result = this.StorageMaster.SelectVehicle(storageName, garageSlots);
                            break;

                        case "LoadVehicle":
                            var products = tokens.Skip(1).ToArray();
                            result = this.StorageMaster.LoadVehicle(products);
                            break;

                        case "SendVehicleTo":
                            var sourceName = tokens[1];
                            var sourceGarageSlots = int.Parse(tokens[2]);
                            var destinationName = tokens[3];
                            result = this.StorageMaster.SendVehicleTo(sourceName, sourceGarageSlots, destinationName);
                            break;

                        case "UnloadVehicle":
                            storageName = tokens[1];
                            garageSlots = int.Parse(tokens[2]);
                            result = this.StorageMaster.UnloadVehicle(storageName, garageSlots);
                            break;

                        case "GetStorageStatus":
                            storageName = tokens[1];
                            result = this.StorageMaster.GetStorageStatus(storageName);
                            break;

                        case "END":
                            result = this.StorageMaster.GetSummary();
                            this.IsRunning = false;
                            break;

                        default:
                            throw new InvalidOperationException("Invalid Command!");
                    }

                }
                catch (InvalidOperationException ex)
                {
                    result = $"Error: {ex.Message}";
                }


                Console.WriteLine(result);
            }
        }
    }
}
