using e_Sport.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Domain.ProductAggregate.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public IEnumerable<Product> GetProductWithScoreGrater(decimal graterThan);
    }
}
