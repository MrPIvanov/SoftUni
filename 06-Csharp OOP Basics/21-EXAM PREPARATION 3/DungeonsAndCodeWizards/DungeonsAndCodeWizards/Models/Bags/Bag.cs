using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonsAndCodeWizards.Models.Bags
{
    public abstract class Bag
    {
        private List<Item> items;

        protected Bag(int capacity)
        {
            this.items = new List<Item>();

            this.Capacity = capacity;
        }

        public int Capacity { get; private set; } = 100;

        public int Load => this.Items.Sum(i => i.Weight);

        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();
       
        public void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            var item = this.items.Where(i => i.GetType().Name == name).FirstOrDefault();

            if (item == null)
            {
                throw new InvalidOperationException($"No item with name {name} in bag!");
            }

            if (this.Items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            this.items.Remove(item);

            return item;
        }

    }
}
