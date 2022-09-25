using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS.Equipment.Amulets
{
    public class AmuletMapping : SubclassMap<Amulet>
    {
        public AmuletMapping()
        {
            KeyColumn("Id");
            Map(e => e.Name);
            Map(e => e.Description);
            References(e => e.Stats).Cascade.AllDeleteOrphan()
                .Not.LazyLoad();
            Map(e => e.EffectsMethod);
            Map(e => e.PlayerClass);

        }
    }


}
