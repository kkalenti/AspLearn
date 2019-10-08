using System.Collections.Generic;

namespace Shop.Data.Models
{
    /// <summary>
    /// Класс для категорий автомобилей
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Id категории
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Описание категории
        /// </summary>
        public string Description { get; set; }


    }
}