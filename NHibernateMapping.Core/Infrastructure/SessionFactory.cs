using NHibernate;

namespace NHibernateMapping.Core.Infrastructure
{
    public class SessionFactory
    {
        static IConfiguration _configuration;

        public SessionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ISessionFactory CreateSessionFactory()
        {
            return _configuration.CreateSessionFactory();
        }
    }
}
