using System;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class OrdersRepository:IAllOrders
    {
        private readonly AppDbContext _appDbContext;

        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDbContext appDbContext, ShopCart shopCart)
        {
            _appDbContext = appDbContext;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDbContext.Order.Add(order);
            _appDbContext.SaveChanges();

            var items = _shopCart.ShopItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = item.Car.Id,
                    OrderId = order.Id,
                    Price = item.Car.Price
                };
                _appDbContext.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}