using System;
using System.Collections.Generic;
using System.Text;
using e_Sport.Domain.OrderAggregate;
using e_Sport.Domain.ProductAggregate;
using e_Sport.Domain.UserAggregate;
using e_Sport.Infrastructure.Repositories;

namespace e_Sport.Application
{
    interface IOrderServices
    {
        public void InitializeOrderIM();
        public void CreateOrder(Order order);
        public void DeleteOrder(Order order);
        public bool ModifyOrderStatus(Order order, OrderStatus status);
        public bool SendOrderToDelivery(Order order);
        public Order CreateOrderBasedOnProducts(IEnumerable<Product> products, User user, string delivery);
        public bool IsOrderReadyToSend(Order order);
    }
}
