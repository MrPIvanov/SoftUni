using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private const int AutomatedWarehouseCapacity = 1;
        private const int AutomatedWarehouseGarageSlots = 2;
        private static Vehicle[] vehicles =
        {
            new Truck()
        };

        public AutomatedWarehouse(string name)
            : base(name, AutomatedWarehouseCapacity, AutomatedWarehouseGarageSlots, vehicles)
        {
        }
    }
}
