using SIS.MvcFramework.Attributes.Security;
using SIS.MvcFramework.Result;
using SMS.App.ViewModels.CartModels;
using SMS.Services;
using System.Linq;

namespace SMS.App.Controllers
{
    public class CartsController : BaseController
    {
        private readonly ICartService cartService;
        private readonly IProductsService productsService;

        public CartsController(ICartService cartService, IProductsService productsService)
        {
            this.cartService = cartService;
            this.productsService = productsService;
        }

        [Authorize]
        public IActionResult Details()
        {
            var userId = this.User.Id;

            var userCart = this.cartService.GetCartForUser(userId);

            var allProducts = this.productsService.GetAll().Where(p => p.CartId == userCart.Id).Select(p => new CartProductsViewModel
            {
                Name = p.Name,
                Price = $"{p.Price:f2}",

            }).ToList();

            return this.View(allProducts);
        }

        [Authorize]
        public IActionResult Buy()
        {
            var userId = this.User.Id;

            this.cartService.ClearAllProductsForUser(userId);

            return this.Redirect("/");
        }

        [Authorize]
        public IActionResult AddProduct(string productId)
        {

            var userId = this.User.Id;

            this.cartService.AddProductInUserCart(userId, productId);

            return this.Redirect("/Carts/Details");
        }
    }
}