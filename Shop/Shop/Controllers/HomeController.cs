using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Contact()
        {
            ViewBag.Title = "Контакты";
            return View();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}