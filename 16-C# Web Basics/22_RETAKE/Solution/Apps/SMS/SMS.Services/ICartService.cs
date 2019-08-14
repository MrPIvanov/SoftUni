using SMS.Models;

namespace SMS.Services
{
    public interface ICartService
    {
        Cart GetCartForUser(string userId);

        bool ClearAllProductsForUser(string userId);

        bool AddProductInUserCart(string userId, string productId);
    }
}
