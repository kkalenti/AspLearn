using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    /// <summary>
    /// Класс для отдельных элементов в корзине
    /// </summary>
    public class ShopCartItem
    {
        /// <summary>
        /// Id объекта
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id объекта в корзине
        /// </summary>
        public string ShopCartId { get; set; }

        /// <summary>
        /// Сам объект
        /// </summary>
        public Car Car { get; set; }

    }
}
