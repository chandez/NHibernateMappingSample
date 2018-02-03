using System.Collections.Generic;
using NHibernate;
using NHibernateMapping.Core.Entities;
using NHibernateMapping.Core.Infrastructure;

namespace NHibernateMapping.Core.Provider
{
    public class UserProvider
    {
        readonly ISessionFactory _sessionFactory;

        public UserProvider(IConfiguration configuration)
        {
            _sessionFactory = new SessionFactory(configuration).CreateSessionFactory();
        }

        public User Get(int id)
        {
            User user;

            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    user = session.QueryOver<User>()
                        .Where(r => r.Id == 1)
                        .SingleOrDefault<User>();
                    transaction.Commit();
                }
            }

            return user;
        }

        public IList<User> List()
        {
            IList<User> users;

            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    users = session.QueryOver<User>()
                        .List<User>();
                    transaction.Commit();
                }
            }

            return users;
        }

    }
}
