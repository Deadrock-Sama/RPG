using FluentNHibernate.Mapping;

namespace Core.PlayerNS.InventoryNS
{
    public class ItemMapping : ClassMap<Item>
    {
        public ItemMapping()
        {
            Id(e => e.Id);
            Map(e => e.Name);
            Map(e => e.Description);
            Map(e => e.EffectsMethod);

        }
    }

}
