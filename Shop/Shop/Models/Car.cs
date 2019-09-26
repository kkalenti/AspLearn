namespace Shop.Models
{
    public class Car
    {
        /// <summary>
        /// Id машины
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название машины
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Краткое описание
        /// </summary>
        public string ShortDescription { get; set; }
        
        /// <summary>
        /// Полное описание
        /// </summary>
        public string FullDescription { get; set; }

        /// <summary>
        /// Краткое описание
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Цена автомобиля
        /// </summary>
        public ushort Price { get; set; }

        /// <summary>
        /// Возвращает true если автомобиль в топе
        /// </summary>
        public bool IsFavourite { get; set; }
        
        /// <summary>
        /// Количество доступных машин
        /// </summary>
        public int AvailableCount { get; set; }

        /// <summary>
        /// Id категории
        /// </summary>
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }



    }
}