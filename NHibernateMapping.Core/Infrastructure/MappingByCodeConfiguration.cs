using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;

namespace NHibernateMapping.Core.Infrastructure
{
    public class MappingByCodeConfiguration : IConfiguration
    {
        #region -- MappingByCode ----------------------------------------------
        public ISessionFactory CreateSessionFactory()
        {
            var cfg = new Configuration()
            .DataBaseIntegration(db =>
            {
                db.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["connection"];
                db.Dialect<MsSql2012Dialect>();
            });

            var mapper = new ModelMapper();
            mapper.AddMappings(Assembly.GetExecutingAssembly().GetExportedTypes());

            var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            cfg.AddMapping(mapping);

            return cfg.BuildSessionFactory();

            //ISession session = factory.OpenSession();
            //ITransaction tx = session.BeginTransaction();
            //session.Get<Person>(1).Dump();
            //tx.Commit();
        }
        #endregion ------------------------------------------------------------
    }
}
