using FluentNHibernate.Mapping;

namespace RPG.Components.Users
{
    public class UserMapping : ClassMap<User>
    {
        public UserMapping()
        {
            Id(e => e.Id);
            Map(e => e.Name);
            Map(e => e.Login);
            Map(e => e.Password);
            Map(e => e.IsAdmin);
        }
    }

}
