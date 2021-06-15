using e_Sport.Domain.OrderAggregate;
using e_Sport.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Application
{
    interface IProductServices
    {
        public void InitializeProductIM();
        public void CreateProduct(Product product);
        public void DeleteProduct(Product order);
        public void DeleteProductById(int id);
    }
}
