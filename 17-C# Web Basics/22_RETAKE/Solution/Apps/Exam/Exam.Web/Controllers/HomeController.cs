using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Result;

namespace Exam.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet(Url = "/")]
        public IActionResult IndexSlash()
        {
            return this.Index();
        }

        public  IActionResult Index()
        {
            if (this.IsLoggedIn())              // If we have 2 views  !!!
            {
                return this.View("IndexLoggedIn");
            }
            else
            {
                return this.View();
            }

            //return this.View();
        }
    }
}
