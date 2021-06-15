using e_Sport.Domain.ProductAggregate;
using FluentNHibernate.Mapping;

namespace e_Sport.Infrastructure.Mappings
{
    class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Price);
            Map(x => x.Score);
            Map(x => x.VolumeWeight);
            Map(x => x.IsActive);
            Map(x => x.Description);
            References(x => x.Producer);
            HasMany(x => x.Comments)
                .Cascade.All();
        }
    }
}
