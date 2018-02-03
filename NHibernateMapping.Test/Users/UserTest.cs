using NHibernateMapping.Core.Infrastructure;
using NHibernateMapping.Core.Provider;
using NUnit.Framework;

namespace NHibernateMapping.Test.Users
{
    [TestFixture]
    public class UserTest
    {
        [Test]
        public void Get_with_MappingByCode()
        {
            var user = new UserProvider(new MappingByCodeConfiguration()).Get(1);
            Assert.AreEqual(1, user.Id);
        }

        [Test]
        public void Get_with_FluentNHibernate()
        {
            var user = new UserProvider(new FluentNHibernateConfiguration()).Get(1);
            Assert.AreEqual(1, user.Id);
        }
    }
}
