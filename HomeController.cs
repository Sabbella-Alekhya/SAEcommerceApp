using Microsoft.AspNetCore.Mvc;
using SAEcommerceApp.Data;

namespace SAEcommerceApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = FakeProductData.GetProducts();
            return View(products);
        }
    }
}
