using DungeonsAndCodeWizards.Models.Items;
using System;

namespace DungeonsAndCodeWizards.Factories
{
    public class ItemFactory
    {
        public Item CreateItem(string type)
        {
            Item item = null;

            switch (type)
            {
                case "ArmorRepairKit":
                    item = new ArmorRepairKit();
                    break;

                case "HealthPotion":
                    item = new HealthPotion();
                    break;

                case "PoisonPotion":
                    item = new PoisonPotion();
                    break;
                
                default:
                    throw new ArgumentException($"Invalid item \"{type}\"!");
            }

            return item;
        }
    }
}
