using System;
using System.Collections.Generic;
using System.Text;
using e_Sport.Domain.Interfaces;

namespace e_Sport.Domain.OrderAggregate
{
    public class OrderPosition : IEntity
    {
        public OrderPosition(ProductAggregate.Product product)
        {
            Product = product;
            Count = 1;
        }
        public OrderPosition(ProductAggregate.Product product, int count)
        {
            Product = product;
            Count = count;
        }
        public ProductAggregate.Product Product { get; set; }
        public int Id { get; set; }
        public int Count { get; set; }
        public decimal GetTotalSum()
        {
            return Count * Product.Price;
        }
        decimal GetTotalVolumeWeight()
        {
            return Count * Product.VolumeWeight;
        }

    }
}
