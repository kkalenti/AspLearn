using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface ICarsCategory
    {
        /// <summary>
        /// Все категории
        /// </summary>
        IEnumerable<Category> AllCategories { get; }
    }
}