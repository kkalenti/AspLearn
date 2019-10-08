﻿using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    /// <summary>
    /// Заглушка для категорий
    /// </summary>
    public class MockCategory : ICarsCategory
    {
        /// <summary>
        /// Инициализируем категории
        /// </summary>
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{ CategoryName = "Электромобили", Description = "Современный вид транспорта"},
                new Category {CategoryName = "Классические автомобили", Description = "Машины с двигателем внутреннего сгорания"}
            };
    }
}