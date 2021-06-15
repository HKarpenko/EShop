using System.Linq;
using System.Collections.Generic;
using e_Sport.Domain;
using e_Sport.Domain.OrderAggregate;
using e_Sport.Domain.ProductAggregate;
using e_Sport.Domain.UserAggregate;
using e_Sport.Domain.OrderAggregate.Repositories;

namespace e_Sport.Infrastructure.Repositories
{
    public class OrderIM : GenericIM<Order>, e_Sport.Domain.OrderAggregate.Repositories.IOrderRepository
    {
        public OrderIM()
        {
            Product pr1 = new Product("Ball for Football", 184.08M);
            Product pr2 = new Product("Fitness Tracker", 99.99M);
            Product pr3 = new Product("Exercise Bike", 568.00M);
            Product pr4 = new Product("Jump Rope", 16.99M);

            User u1 = new User("John Doe", "john.doe@email.com");
            User u2 = new User("Sara Doe", "sara.doe@email.com");

            u1.Adress = new Adress("Poland", "Wroclaw", "Teczowa, 27/2");

            Order o1 = new Order(u1, "DHL");
            o1.SetUsersDefaultAdress();
            o1.AddNewPosition(new OrderPosition(pr1, 3));
            o1.AddNewPosition(new OrderPosition(pr2, 1));

            Order o2 = new Order(u1, "DHL");
            o2.SetUsersDefaultAdress();
            o2.AddNewPosition(new OrderPosition(pr3, 1));
            o2.AddNewPosition(new OrderPosition(pr4, 2));

            Order o3 = new Order(u2, "InPost"); 
            o3.Adress = new Adress("Poland", "Warsaw", "Łęczycka, 15/5");
            o3.AddNewPosition(new OrderPosition(pr1, 10));

            instances.Add(o1);
            instances.Add(o2);
            instances.Add(o3);
        }
     
        public IEnumerable<Order> GetOrdersInPriceRange(decimal from, decimal to)
        {
            return instances.Where(o => (o.TotalPrice >= from && o.TotalPrice <= to));
        }
    }
}
