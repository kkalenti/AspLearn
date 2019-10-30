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
            return View();
        }
    }
}