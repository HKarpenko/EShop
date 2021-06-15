using e_Sport.Domain.ProductAggregate;
using FluentNHibernate.Mapping;

namespace e_Sport.Infrastructure.Mappings
{
    class CommentMap : ClassMap<ProductOverviewComment>
    {
        public CommentMap()
        {
            Id(x => x.Id);
            Map(x => x.Likes);
            Map(x => x.Dislikes);
            Map(x => x.Text);
        }
    }
}
