using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _allCars;

        private readonly ICarsCategory _allCategories;

        public CarsController(ICars allCars, ICarsCategory allCategories)
        {
            _allCars = allCars;
            _allCategories = allCategories;
        }

        public IActionResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            var carList = new CarsListViewModel();
            carList.AllCars = _allCars.AllCars;
            carList.CurrentCategory = "Автомобили";
            return View(carList);
        }
    }
}