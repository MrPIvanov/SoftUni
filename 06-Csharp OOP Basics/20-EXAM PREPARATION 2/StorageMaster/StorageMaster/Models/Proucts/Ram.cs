namespace StorageMaster.Models.Proucts
{
    public class Ram : Product
    {
        private const double RamPrice = 0.1;

        public Ram(double price) : base(price, RamPrice)
        {
        }
    }
}
