using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Контекст базы данных
        /// </summary>
        /// <param name="options">База данных</param>
        public AppDbContext(DbContextOptions options) : base(options)
        {}

        /// <summary>
        /// Модель автомобилей
        /// </summary>
        public DbSet<Car> Cars { get; set; }

        /// <summary>
        /// Модель категорий
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Модель элементов в корзине
        /// </summary>
        public DbSet<ShopCartItem>  ShopCartItems { get; set; }

        /// <summary>
        /// Модель заказа
        /// </summary>
        public DbSet<Order> Order { get; set; }

        /// <summary>
        /// Модель деталей заказа
        /// </summary>
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}