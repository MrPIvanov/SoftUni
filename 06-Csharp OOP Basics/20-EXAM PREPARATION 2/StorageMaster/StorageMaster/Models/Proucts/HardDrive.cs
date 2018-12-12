namespace StorageMaster.Models.Proucts
{
    public class HardDrive : Product
    {
        private const double HardDrivePrice = 1.0;

        public HardDrive(double price) : base(price, HardDrivePrice)
        {
        }
    }
}
