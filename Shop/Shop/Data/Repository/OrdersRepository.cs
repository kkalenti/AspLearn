using System;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class OrdersRepository:IAllOrders
    {
        private readonly AppDbContent _appDbContent;

        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDbContent appDbContent, ShopCart shopCart)
        {
            _appDbContent = appDbContent;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDbContent.Order.Add(order);

            var items = _shopCart.ShopItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = item.Car.Id,
                    OrderId = order.Id,
                    Price = item.Car.Price
                };
                _appDbContent.OrderDetails.Add(orderDetail);
            }

            _appDbContent.SaveChanges();
        }
    }
}