namespace SMS.App.Controllers
{
    using System;
    using System.Linq;
    using SIS.MvcFramework.Attributes;
    using SIS.MvcFramework.Result;
    using SMS.App.ViewModels.HomeModels;
    using SMS.Services;

    public class HomeController : BaseController
    {
        private readonly IUsersService usersService;
        private readonly IProductsService productsService;

        public HomeController(IUsersService usersService, IProductsService productsService)
        {
            this.usersService = usersService;
            this.productsService = productsService;
        }

        [HttpGet(Url = "/")]
        public IActionResult IndexSlash()
        {
            return this.Index();
        }

        public IActionResult Index()
        {
            if (this.IsLoggedIn())
            {
                var user = usersService.GetUserOrNull(this.User.Id);

                var allProducts = this.productsService.GetAll().Select(x => new ProductListingViewModel
                {   
                     Id = x.Id,
                     Name = x.Name,
                     Price = $"{x.Price:f2}",
                })
                    .ToList();


                return this.View(allProducts, "IndexLoggedIn");
            }
            else
            {
                return this.View();
            }
        }
    }
}