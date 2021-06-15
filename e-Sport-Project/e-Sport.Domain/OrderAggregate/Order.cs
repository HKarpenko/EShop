using System;
using System.Collections.Generic;
using System.Text;
using e_Sport.Domain.Interfaces;

namespace e_Sport.Domain.OrderAggregate
{
    public class Order : IEntity 
    {
        private static int counter = 1;
        public Order(UserAggregate.User user, string delivery)
        {
            Creator = user;
            Delivery = delivery;
            Id = counter;
            counter++;
        }
        public int Id { get; set; }
        public decimal TotalPrice { get; private set; }
        public OrderStatus Status { get; set; }
        public decimal VolumeWeight { get; set; }
        public List<OrderPosition> OrderPositions { get; private set; }
        public Payment Payment { get; private set; }
        public string Delivery { get; set; }
        public Adress Adress { get; set; }
        private UserAggregate.User Creator { get; set; }

        public Dictionary<string,string> GetUserDataForm()
        {
            Dictionary<string, string> form = new Dictionary<string, string>();
            form.Add("Name", Creator.UserName);
            form.Add("Delivery", Delivery);
            Adress deliveryAdress = Adress ?? (Creator.Adress ?? throw new NullReferenceException("Trying to send on unknown adress"));

            return form;
        }
        public void AddNewPosition(OrderPosition position)
        {
            OrderPositions.Add(position);
            TotalPrice += position.GetTotalSum();
        }
        public void RemovePosition(OrderPosition position)
        {
            bool isRemoved = OrderPositions.Remove(position);
            if (isRemoved)
            {
                TotalPrice -= position.GetTotalSum();
            }
        }
        public void SetUsersDefaultAdress()
        {
            Adress = Creator.Adress;
        }
        public bool IsPayed()
        {
            return Payment.IsPayed;
        }
        public void Pay(string system)
        {
            if(Payment == null)
                Payment = new Payment(system);
            Payment.IsPayed = true;
        }
    }
}
