using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Mediator.Data
{
    class Helper
    {
        private const string AzureConnectionString = "Server=tcp:aa3odzvg0b.database.windows.net,1433;Database=Cycling;User ID=Ed;Password=pluto.13520;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private static ISessionFactory _sessionFactory;

        public static ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = Fluently.Configure()
                    .Database(GetDatabaseConfiguration())
                    .Mappings((x) => x.FluentMappings.AddFromAssemblyOf<Model.Model>()
                        .Conventions.Setup((y) => y.Add(FluentNHibernate.Conventions.Helpers.AutoImport.Never())))
                    .BuildSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }

        public static MsSqlConfiguration GetDatabaseConfiguration()
        {
            var configuration = MsSqlConfiguration.MsSql2012.ConnectionString(AzureConnectionString);
#if DEBUG
            configuration.ShowSql();
            configuration.FormatSql();
#endif
            return configuration;
        }
    }
}