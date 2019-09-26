using System.Collections.Generic;

namespace Shop.Models
{
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

        /// <summary>
        /// Список машин входящих в категорию
        /// </summary>
        public List<Car> CarList { get; set; }


    }
}