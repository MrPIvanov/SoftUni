using System.Linq;
using SMS.Data;
using SMS.Models;

namespace SMS.Services
{
    public class ProductsService : IProductsService
    {
        private readonly SMSContext db;

        public ProductsService(SMSContext db)
        {
            this.db = db;
        }

        public void Create(string name, decimal price)
        {
            var product = new Product
            {
                 Name = name,
                 Price = price,
            };

            db.Products.Add(product);
            db.SaveChanges();
        }

        public IQueryable<Product> GetAll()
        {
            return this.db.Products;
        }
    }
}
