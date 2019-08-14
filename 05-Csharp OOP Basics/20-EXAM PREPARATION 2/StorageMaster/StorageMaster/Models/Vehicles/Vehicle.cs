using StorageMaster.Models.Proucts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Models.Vehicles
{
    public abstract class Vehicle
    {
        public int Capacity { get; private set; }

        private List<Product> products;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.products = new List<Product>();
        }

        public IReadOnlyCollection<Product> Trunk => this.products.AsReadOnly();

        public bool IsFull => this.Trunk.Sum(p => p.Weight) >= this.Capacity;

        public bool IsEmpty => this.Trunk.Count == 0;

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            this.products.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            var product = this.products.Last();

            this.products.RemoveAt(this.Trunk.Count - 1);

            return product;
        }
    }
}
