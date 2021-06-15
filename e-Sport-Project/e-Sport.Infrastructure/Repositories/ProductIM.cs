using System.Collections.Generic;
using System.Linq;
using e_Sport.Domain.ProductAggregate;

namespace e_Sport.Infrastructure.Repositories
{
    public class ProductIM : GenericIM<Product>, e_Sport.Domain.ProductAggregate.Repositories.IProductRepository
    {
        public ProductIM()
        {
            instances.Add(new Product("Ball for Football", 184.08M) );
            instances.Add(new Product("Fitness Tracker", 99.99M));
            instances.Add(new Product("Exercise Bike", 568.00M));
            instances.Add(new Product("Jump Rope", 16.99M));
        }
        public IEnumerable<Product> GetProductWithScoreGrater(decimal graterThan)
        {
            return instances.Where(p => p.Score > graterThan);
        }
    }
}
