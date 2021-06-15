using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Domain.UserAggregate
{
    public class Basket
    {
        public Basket(User user)
        {
            Owner = user;
        }
        public User Owner { get; set; }
        private OrderAggregate.Order Order { get; set; }
        public void Reset()
        {
            Order = new OrderAggregate.Order(Owner, Owner.getDefaultDelivery());
        }
        public void AddNewPosition(OrderAggregate.OrderPosition position)
        {
            Order.OrderPositions.Add(position);
        }
        public decimal GetTotalPrice()
        {
            return Order.TotalPrice;
        }

    }
}
