using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernateMapping.Core.Entities;
using NHibernate;
using NHibernate.Cfg;

namespace NHibernateMapping.Core.Infrastructure
{
    public class FluentNHibernateConfiguration : IConfiguration
    {
        #region -- FluentNHibernate -------------------------------------------
        public ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2012
                    .ConnectionString(System.Configuration.ConfigurationManager.AppSettings["connection"])
                    //.Cache(c => c.UseQueryCache())
                    .ShowSql()
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<User>())
                //.ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();
        }

        private static void BuildSchema(Configuration config)
        {
            new SchemaExport(config)
                .Create(false, true);
        }
        #endregion ------------------------------------------------------------
    }
}
