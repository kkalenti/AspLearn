using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICars _car;

        private readonly ShopCart _shopCart;

        public CartController(ICars car, ShopCart shopCart)
        {
            _car = car;
            _shopCart = shopCart;
        }

        public IActionResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ShopItems = items;

            var ShopCart  = new ShopCartViewModel()
            {
                ShopCart = _shopCart
            };

            return View(ShopCart);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _car.GetCar(id);

            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}                             