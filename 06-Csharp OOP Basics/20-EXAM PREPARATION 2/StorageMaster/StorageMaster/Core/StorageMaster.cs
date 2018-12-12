using StorageMaster.Factories;
using StorageMaster.Models.Proucts;
using StorageMaster.Models.Storages;
using StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private List<Product> AllProducts { get; set; }

        private List<Storage> AllStorages { get; set; }

        private ProductFactory ProductFactory { get; set; }

        private StorageFactory StorageFactory { get; set; }

        private VehicleFactory VehicleFactory { get; set; }

        private Vehicle CurrentVehicle { get; set; }


        public StorageMaster()
        {
            this.AllProducts = new List<Product>();

            this.AllStorages = new List<Storage>();

            this.ProductFactory = new ProductFactory();

            this.StorageFactory = new StorageFactory();

            this.VehicleFactory = new VehicleFactory();
        }

        public string AddProduct(string type, double price)
        {
            var product = this.ProductFactory.CreateProduct(type, price);

            this.AllProducts.Add(product);

            var result = $"Added {product.GetType().Name} to pool";
            return result;
        }

        public string RegisterStorage(string type, string name)
        {
            var storage = this.StorageFactory.CreateStorage(type, name);

            this.AllStorages.Add(storage);


            var result = $"Registered {name}";
            return result;
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            var storage = this.AllStorages.Where(s => s.Name == storageName).FirstOrDefault();

            this.CurrentVehicle = storage.GetVehicle(garageSlot);


            var result = $"Selected {this.CurrentVehicle.GetType().Name}";
            return result;
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            var loadedProductsCount = 0;
            foreach (var product in productNames)
            {
                if (!this.CurrentVehicle.IsFull)
                {
                    var currentProduct = this.AllProducts.Where(p => p.GetType().Name == product).LastOrDefault();

                    if (currentProduct == null)
                    {
                        throw new InvalidOperationException($"{product} is out of stock!");
                    }

                    this.CurrentVehicle.LoadProduct(currentProduct);
                    loadedProductsCount++;

                    this.AllProducts.Remove(currentProduct);
                }
            }
            var result = $"Loaded {loadedProductsCount}/{productNames.Count()} products into {this.CurrentVehicle.GetType().Name}";
            return result;
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            var sourceStorage = this.AllStorages.Where(s => s.Name == sourceName).FirstOrDefault();
            var destinationStorage = this.AllStorages.Where(s => s.Name == destinationName).FirstOrDefault();

            if (sourceStorage == null)
            {
                throw new InvalidOperationException("Invalid source storage!");
            }


            if (destinationStorage == null)
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            var vehicleType = sourceStorage.GetVehicle(sourceGarageSlot).GetType().Name;

            var destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);

            var result = $"Sent {vehicleType} to {destinationName} (slot {destinationGarageSlot})";
            return result;
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            var storage = this.AllStorages.Where(s => s.Name == storageName).FirstOrDefault();

            var productsInVehicle = storage.GetVehicle(garageSlot).Trunk.Count;

            var unloadedProductsCount = storage.UnloadVehicle(garageSlot);


            var result = $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";
            return result;
        }

        public string GetStorageStatus(string storageName)
        {
            var storage = this.AllStorages.Where(s => s.Name == storageName).FirstOrDefault();

            var productDict = new Dictionary<string, List<Product>>();

            foreach (var product in storage.Products)
            {
                var productName = product.GetType().Name;

                if (!productDict.ContainsKey(productName))
                {
                    productDict[productName] = new List<Product>();
                }

                productDict[productName].Add(product);
            }

            var sumOfTheProductsWeight = 0.0;

            foreach (var item in productDict)
            {
                sumOfTheProductsWeight += item.Value.Sum(p => p.Weight);
            }

            var storageCapacity = storage.Capacity;

            var allInfoLines = new List<string>();

            foreach (var item in productDict)
            {
                allInfoLines.Add($"{item.Key} ({item.Value.Count})");
            }

            var stockLine = $"Stock ({sumOfTheProductsWeight}/{storageCapacity}): [{string.Join(", ", allInfoLines)}]";



            var garage = storage.Garage.ToArray();
            var garegePrint = new string[garage.Length];

            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i] == null)
                {
                    garegePrint[i] = "empty";
                }
                else
                {
                    garegePrint[i] = garage[i].GetType().Name;
                }
            }

            var garageLine = $"Garage: [{string.Join("|", garegePrint)}]";

            var result = $"{stockLine}{ Environment.NewLine}{garageLine}";
            return result;
        }

        public string GetSummary()
        {
            var orderedStorages = this.AllStorages.OrderByDescending(s => s.Products.Sum(p => p.Price)).ToArray()
                .Select(x => $"{x.Name}:{Environment.NewLine}Storage worth: ${x.Products.Sum(p => p.Price):F2}").ToArray();

            var result = $"{string.Join(Environment.NewLine, orderedStorages)}";
            return result;
        }

    }
}
