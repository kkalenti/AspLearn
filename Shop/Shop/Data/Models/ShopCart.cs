using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContent _dbContent;

        public ShopCart(AppDbContent appDbContent)
        {
            _dbContent = appDbContent;
        }

        public string Id { get; set; }

        public List<ShopCartItem> ShopItems
        {
            get
            {
                return _dbContent.ShopCartItems.Where(c => c.ShopCartId == Id).
                    Include(s => s.Car).ToList();
            }
        }

        public static ShopCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDbContent>();
            var shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context)
            {
                Id = shopCartId
            };
        }

        public void AddToCart(Car car)
        {
            _dbContent.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = Id,
                Car = car
            });

            _dbContent.SaveChanges();
        }
    }
}