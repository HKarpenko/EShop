using System;
using System.Collections.Generic;
using System.Text;
using e_Sport.Domain.OrderAggregate;
using e_Sport.Domain.Repositories;

namespace e_Sport.Domain.OrderAggregate.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        public IEnumerable<Order> GetOrdersInPriceRange(decimal from, decimal to);
    }
}
