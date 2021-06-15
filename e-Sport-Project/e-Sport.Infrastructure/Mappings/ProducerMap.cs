using e_Sport.Domain;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Infrastructure.Mappings
{
    class ProducerMap : ClassMap<Producer>
    {
        public ProducerMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.VAT);
        }
    }
}
