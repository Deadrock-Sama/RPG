using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS
{
    public class ItemControllerMapping : ClassMap<ItemController>
    {
        public ItemControllerMapping()
        {
            Id(e => e.Id);
            Map(e => e.Count);
            References(e => e.Player).Cascade.AllDeleteOrphan()
               .Not.LazyLoad()
               .Not.Nullable();
            References(e => e.Item).Cascade.AllDeleteOrphan()
               .Not.LazyLoad()
               .Not.Nullable();

        }
    }

}
