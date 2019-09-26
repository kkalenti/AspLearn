using System.Collections;
using System.Collections.Generic;
using Shop.Interfaces;
using Shop.Models;

namespace Shop.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{ CategoryName = "Электромобили", Description = "Современный вид транспорта"},
                new Category {CategoryName = "Классические автомобили", Description = "Машины с двигателем внутреннего сгорания"}
            };
    }
}