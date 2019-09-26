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



        public ushort Price { get; set; }

        public bool IsFavourite { get; set; }

        public int AvailableCount { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }



    }
}