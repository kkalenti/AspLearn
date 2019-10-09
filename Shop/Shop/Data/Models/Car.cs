namespace Shop.Data.Models
{
    /// <summary>
    /// Класс для автомобилей
    /// </summary>
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
        /// Url к картинке машины
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
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Id категории
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Сама категория
        /// </summary>
        public virtual Category Category { get; set; }



    }
}