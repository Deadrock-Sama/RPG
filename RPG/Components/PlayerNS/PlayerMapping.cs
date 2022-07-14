using FluentNHibernate.Mapping;

namespace RPG.Components.PlayerNS
{
    public class PlayerMapping : ClassMap<Player>
    {
        public PlayerMapping()
        {
            Id(e => e.Id);

            References(e => e.Info).Cascade.AllDeleteOrphan();
        }
    }
}
