using NHibernate;

namespace NHibernateMapping.Core.Infrastructure
{
    public interface IConfiguration
    {
        ISessionFactory CreateSessionFactory();
    }
}
