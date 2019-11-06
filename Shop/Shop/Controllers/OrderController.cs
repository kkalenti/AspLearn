using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private IAllOrders _allOrders;

        private ShopCart _shopCart;

        public OrderController(ShopCart shopCart, IAllOrders allOrders)
        {
            _shopCart = shopCart;
            _allOrders = allOrders;
        }

        public IActionResult Checkout()
        {
            if (_shopCart.ShopItems.Count != 0) return View();

            return Redirect("/Cart/");

        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (ModelState.IsValid)
            {
                _allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}