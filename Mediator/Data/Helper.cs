using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Mediator.Data
{
    class Helper
    {
        private static ISessionFactory SessionFactory
        {
            get
            {
                return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(m => m.Server("tcp: aa3odzvg0b.database.windows.net, 1433")
                        .Database("Cycling")
                        .Username("Ed")
                        .Password("pluto.13520")))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}