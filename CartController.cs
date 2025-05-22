using Microsoft.AspNetCore.Mvc;
using SAEcommerceApp.Data;
using SAEcommerceApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace SAEcommerceApp.Controllers
{
    public class CartController : Controller
    {
        private const string SessionCartKey = "CartItems";

        // Helper: Get product list from session
        private List<int> GetCart()
        {
            var sessionData = HttpContext.Session.GetString(SessionCartKey);
            if (sessionData == null) return new List<int>();
            return JsonSerializer.Deserialize<List<int>>(sessionData) ?? new List<int>();
        }

        // Helper: Save product list to session
        private void SaveCart(List<int> cart)
        {
            HttpContext.Session.SetString(SessionCartKey, JsonSerializer.Serialize(cart));
        }

        // Show Cart page
        public IActionResult Index()
        {
            var cart = GetCart();
            var products = FakeProductData.GetProducts()
                .Where(p => cart.Contains(p.Id)).ToList();

            return View(products);
        }

        // Add product to cart
        public IActionResult AddToCart(int id)
        {
            var cart = GetCart();

            if (!cart.Contains(id))
                cart.Add(id);

            SaveCart(cart);

            return RedirectToAction("Index", "Home");
        }

        // Remove product from cart
        public IActionResult Remove(int id)
        {
            var cart = GetCart();

            if (cart.Contains(id))
                cart.Remove(id);

            SaveCart(cart);

            return RedirectToAction("Index");
        }

        // Checkout action
        public IActionResult Checkout()
        {
            // Clear cart
            SaveCart(new List<int>());

            TempData["CheckoutMessage"] = "Order placed successfully!";
            return RedirectToAction("Index");
        }
    }
}
