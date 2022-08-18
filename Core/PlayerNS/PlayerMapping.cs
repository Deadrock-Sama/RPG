using FluentNHibernate.Mapping;

namespace Core.PlayerNS
{
    public class PlayerMapping : ClassMap<Player>
    {
        public PlayerMapping()
        {
            Id(e => e.Id);

            References(e => e.Info)
                .Cascade.AllDeleteOrphan()
                .Not.LazyLoad();
            References(e => e.User)
                .Cascade.AllDeleteOrphan()
                .Not.LazyLoad()
                .Not.Nullable();
            References(e => e.PlayerClass)
                .Cascade.AllDeleteOrphan()
                .Not.LazyLoad()
                .Not.Nullable();
        }
    }
}
