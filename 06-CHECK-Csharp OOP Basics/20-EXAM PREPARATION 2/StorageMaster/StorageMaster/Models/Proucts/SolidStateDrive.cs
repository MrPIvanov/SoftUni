namespace StorageMaster.Models.Proucts
{
    public class SolidStateDrive : Product
    {
        private const double SolidStateDrivePrice = 0.2;

        public SolidStateDrive(double price) : base(price, SolidStateDrivePrice)
        {
        }
    }
}
