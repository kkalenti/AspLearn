using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICars _cars;

        private readonly ShopCart _shopCart;

        public CartController(ICars cars, ShopCart shopCart)
        {
            _cars = cars;
            _shopCart = shopCart;
        }

        public IActionResult Index()
        {
            var shopCart  = new ShopCartViewModel()
            {
                ShopCart = _shopCart
            };

            return View(shopCart);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _cars.GetCar(id);

            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}                             