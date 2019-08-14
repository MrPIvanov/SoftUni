using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public class Warehouse : Storage
    {
        private const int WarehouseCapacity = 10;
        private const int WarehouseGarageSlots = 10;
        private static Vehicle[] vehicles =
        {
            new Semi(),
            new Semi(),
            new Semi()
        };

        public Warehouse(string name)
            : base(name, WarehouseCapacity, WarehouseGarageSlots, vehicles)
        {
        }
    }
}
