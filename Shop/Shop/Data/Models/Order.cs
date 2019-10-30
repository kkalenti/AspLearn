using System;
using System.Collections.Generic;

namespace Shop.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        
        public string Email { get; set; }

        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}