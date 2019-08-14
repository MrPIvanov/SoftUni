using SMS.Data;
using SMS.Models;
using System.Collections.Generic;
using System.Linq;

namespace SMS.Services
{
    public class CartService : ICartService
    {
        private readonly SMSContext db;

        public CartService(SMSContext db)
        {
            this.db = db;
        }

        public bool AddProductInUserCart(string userId, string productId)
        {
            var currentCart = this.GetCartForUser(userId);

            //var products = this.db.Products.Where(p => p.CartId == currentCart.Id);

            var product = this.db.Products.FirstOrDefault(p => p.Id == productId);

            currentCart.Products.Add(product);

            product.Cart = currentCart;
            product.CartId = currentCart.Id;

            this.db.Update(product);
            this.db.Update(currentCart);
            this.db.SaveChanges();

            return true;
        }

        public bool ClearAllProductsForUser(string userId)
        {
            var cart = this.db.Carts.FirstOrDefault(c => c.UserId == userId);

            var allProducts = this.db.Products.Where(p => p.CartId == cart.Id).ToList();

            this.db.Products.RemoveRange(allProducts);

            this.db.SaveChanges();

            return true;
        }

        public Cart GetCartForUser(string userId)
        {
            return this.db.Carts.FirstOrDefault(c => c.UserId == userId);
        }
    }
}
