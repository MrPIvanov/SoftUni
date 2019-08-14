using SMS.Models;
using System.Linq;

namespace SMS.Services
{
    public interface IProductsService
    {
        IQueryable<Product> GetAll();

        void Create(string name, decimal price);
    }
}
