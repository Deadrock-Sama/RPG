using FluentNHibernate.Mapping;
using RPG.DBInteraction.Mappings;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Food
{
    public class Item : DbEntity, IInventoryItem
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string EffectsMethod { get; set; }
    }

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
