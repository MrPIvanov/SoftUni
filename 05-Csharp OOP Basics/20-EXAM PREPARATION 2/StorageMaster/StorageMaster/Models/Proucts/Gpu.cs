namespace StorageMaster.Models.Proucts
{
    public class Gpu : Product
    {
        private const double GpuPrice = 0.7;

        public Gpu(double price) : base(price, GpuPrice)
        {
        }
    }
}
