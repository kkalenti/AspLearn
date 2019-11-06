namespace Shop.Data.Models
{
    /// <summary>
    /// Клас информации о заказе
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// Id детали заказа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id заказа
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Id заказанного автомобиля
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// Цена автомобиля
        /// </summary>
        public int Price { get; set; }

        public virtual Car Car { get; set; }

        public virtual Order Order { get; set; }
    }
}