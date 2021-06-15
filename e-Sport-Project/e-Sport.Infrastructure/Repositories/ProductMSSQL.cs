using e_Sport.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Cfg;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using System.Reflection;
using System.Linq;

namespace e_Sport.Infrastructure.Repositories
{
    public class ProductMSSQL
    {
        ISession session;
        public ProductMSSQL() 
        {
            session = Helpers.NHibernateHelper.GetCurrentSession();
        }
        public void Add(Product obj)
        {
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    session.Save(obj);
                    tx.Commit();
                }
            }
            finally
            {
                Helpers.NHibernateHelper.CloseSession();
            }
        }

        public Product Find(int id)
        {
            ITransaction tx2 = session?.BeginTransaction();
            Product pr = session.Query<Product>()
                .FirstOrDefault(x => x.Id == id);
            tx2.Commit();
            return pr;
        }

        public IEnumerable<Product> GetAll()
        {
            ITransaction tx2 = session?.BeginTransaction();
            IList<Product> prs = session.Query<Product>().ToList();
            tx2.Commit();
            return prs;
        }

        public bool Remove(int id)
        {
            ITransaction tx2 = session.BeginTransaction();

            var product = session.Get<Product>(id);
            session.Delete(product);

            tx2.Commit();
            return product != null;

        }

        public Product Contains(Product obj)
        {
            ITransaction tx2 = session?.BeginTransaction();
            Product pr = session.Query<Product>()
                .FirstOrDefault(x => x.Id == obj.Id);
            tx2.Commit();
            return pr;
        }

    }
}
