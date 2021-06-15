using e_Sport.Domain.OrderAggregate;
using e_Sport.Domain.ProductAggregate;
using e_Sport.Domain.UserAggregate;
using e_Sport.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Application
{
    class OrderServices : IOrderServices
    {
        public OrderIM orders { get; private set; }
        public void CreateOrder(Order order)
        {
            orders.Add(order);
        }

        public Order CreateOrderBasedOnProducts(IEnumerable<Product> products, User user, string delivery=null)
        {
            delivery = delivery ?? user.getDefaultDelivery();
            Order order = new Order(user, delivery);
            foreach(Product product in products)
            {
                order.AddNewPosition(new OrderPosition(product));
            }
            return order;
        }

        public void DeleteOrder(Order order)
        {
            orders.Remove(order);
        }

        public void InitializeOrderIM()
        {
            orders = new OrderIM();
        }

        public bool ModifyOrderStatus(Order order, OrderStatus status)
        {
            if (status == OrderStatus.Paid && !IsOrderReadyToSend(order))
                return false;
            order.Status = status;
            return true;
        }

        public bool IsOrderReadyToSend(Order order)
        {
            return order.IsPayed() && order.Adress.isValid() && order.Delivery != null && order.OrderPositions.Count > 0;
        }

        public bool SendOrderToDelivery(Order order)
        {
            if (IsOrderReadyToSend(order))
            {
                // Send with some API
                return true;
            }
            return false;
        }
    }
}
