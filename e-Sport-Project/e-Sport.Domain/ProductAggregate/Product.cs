using System;
using System.Collections.Generic;
using System.Text;
using e_Sport.Domain.Interfaces;

namespace e_Sport.Domain.ProductAggregate
{
    public class Product : IEntity
    {
        public static int counter = 1;
        public Product()
        {
            Id = counter;
            counter++;
        }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            Id = counter;
            counter++;
        }
        public virtual int Id { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal VolumeWeight { get; set; }
        public virtual string Name { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual decimal Score { get; set; }
        public virtual string Description { get; set; }
        public virtual IEnumerable<ProductOverviewComment> Comments { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
