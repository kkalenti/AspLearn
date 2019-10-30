using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
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

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public IActionResult List(string category)
        {
            IEnumerable<Car> cars = null;
            string currentCategory = null;

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.AllCars.OrderBy(i => i.Id);
                currentCategory = "";
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.AllCars.Where(i => i.Category.CategoryName.Equals("Электромобили"))
                        .OrderBy(i => i.Id);
                    currentCategory = category;
                }
                else if (string.Equals("classic", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.AllCars.Where(i => i.Category.CategoryName.Equals("Классические автомобили"))
                        .OrderBy(i => i.Id);
                    currentCategory = category;
                }

            }

            ViewBag.Title = "Страница с автомобилями";
            var carList = new CarsListViewModel { AllCars = cars, CurrentCategory = currentCategory };

            return View(carList);
        }
    }
}