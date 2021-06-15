using e_Sport.Domain.OrderAggregate;
using e_Sport.Domain.ProductAggregate;
using e_Sport.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Application
{
    class ProductsServices : IProductServices
    {
        public ProductIM products { get; private set; }

        public void CreateProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            products.Remove(product);
        }

        public void DeleteProductById(int id)
        {
            products.RemoveWhere(new Predicate<Product>(p => p.Id == id));
        }

        public void InitializeProductIM()
        {
            products = new ProductIM();
        }
    }
}
