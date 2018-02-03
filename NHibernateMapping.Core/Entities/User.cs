namespace NHibernateMapping.Core.Entities
{
    public class User
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
    }
}
