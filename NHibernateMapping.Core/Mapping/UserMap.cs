using NHibernate.Mapping.ByCode.Conformist;
using NHibernateMapping.Core.Entities;
using NHibernate.Mapping.ByCode;
//using FluentNHibernate.Mapping;

namespace NHibernateMapping.Core.Mapping
{
    #region -- MappingByCode ----------------------------------------------
    public class UserrMap : ClassMapping<User>
    {
        public UserrMap()
        {
            Id(x => x.Id, map => map.Column("id"));
            Property(x => x.Name, map => map.Column("name"));
            Property(x => x.Email, map => map.Column("email"));
            Table("[dbo].[User]");
        }
    }
    #endregion ------------------------------------------------------------
    #region -- FluentNHibernate -------------------------------------------
    //public class UserMap : ClassMap<User>
    //{
    //    public UserMap()
    //    {
    //        Id(x => x.Id, "id");
    //        Map(x => x.Name, "name");
    //        Map(x => x.Email, "email");
    //        Table("User");
    //    }
    //}
    #endregion ------------------------------------------------------------
}
