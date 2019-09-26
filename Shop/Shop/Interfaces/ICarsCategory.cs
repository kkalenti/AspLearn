using System.Collections;
using System.Collections.Generic;
using Shop.Models;

namespace Shop.Interfaces
{
    public interface ICarsCategory
    {
        /// <summary>
        /// Все категории
        /// </summary>
        IEnumerable<Category> AllCategories { get; }
    }
}