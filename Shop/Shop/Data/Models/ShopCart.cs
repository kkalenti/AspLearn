using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Data.Models
{
    /// <summary>
    /// Класс корзины покупок
    /// </summary>
    public class ShopCart
    {
        /// <summary>
        /// Контекст базы данных
        /// </summary>
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// Конструктор класса <see cref="ShopCart"/>
        /// </summary>
        /// <param name="appDbContext">Контекст базы данных</param>
        public ShopCart(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        /// <summary>
        /// Id корзины для покупок
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Возвращает товары в корзине из базы данных
        /// </summary>
        public List<ShopCartItem> ShopItems
        {
            get
            {
                return _dbContext.ShopCartItems.Where(c => c.ShopCartId == Id).
                    Include(s => s.Car).ToList();
            }
        }

        /// <summary>
        /// Создание нового объекта корзины покупок
        /// </summary>
        /// <param name="service">Сервис</param>
        /// <returns>Новая корзина покупок</returns>
        public static ShopCart GetCart(IServiceProvider service)
        {
            var session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDbContext>();
            var shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context)
            {
                Id = shopCartId
            };
        }

        /// <summary>
        /// Добавить элемент в корзину
        /// </summary>
        /// <param name="car">Добавляемый элемент</param>
        public void AddToCart(Car car)
        {
            _dbContext.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = Id,
                Car = car
            });

            _dbContext.SaveChanges();
        }

        public void DeleteFromCart(int id)
        {
            var item = _dbContext.ShopCartItems.Find(id);
            _dbContext.ShopCartItems.Remove(item);

            _dbContext.SaveChanges();
        }
    }
}