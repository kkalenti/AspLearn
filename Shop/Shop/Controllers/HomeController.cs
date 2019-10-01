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
        private readonly IContacts _contacts;

        public HomeController(IContacts contacts)
        {
            _contacts = contacts;
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Контакты";
            ViewBag.Contact = "Наши контакты:";
            var contactView = new ContactViewModel {Contacts = _contacts.Contact};
            return View(contactView);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}