using e_Sport.Infrastructure.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace e_Sport.Infrastructure.Helpers
{
    public class NHibernateHelper
    {
        private const string CurrentSessionKey = "nhibernate.current_session";
        private static readonly ISessionFactory _sessionFactory = FluentConfigure();

        public static ISession GetCurrentSession()
        {
            return _sessionFactory.OpenSession();
        }
        public static void CloseSession()
        {
            _sessionFactory.Close();
        }
        public static void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }

        public static ISessionFactory FluentConfigure()
        {

            return Fluently.Configure()
                //which database
                .Database(
                    MsSqlConfiguration.MsSql2012
                        .ConnectionString("Data Source=DESKTOP-Q4K2179\\SQLEXPRESS;Initial Catalog=e-Sport;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                //find/set the mappings
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMap>())
                .BuildSessionFactory();
        }
    }
}
