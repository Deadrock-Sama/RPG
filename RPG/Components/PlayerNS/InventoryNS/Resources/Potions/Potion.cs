using FluentNHibernate.Mapping;
using RPG.DBInteraction.Mappings;

namespace RPG.Components.PlayerNS.InventoryNS.Resources.Potions
{
    public class Potion : DbEntity, IInventoryItem
    {

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

    }

    public class PotionMapping : ClassMap<Potion>
    {
        public PotionMapping()
        {
            Id(e => e.Id);
            Map(e => e.Name);
            Map(e => e.Description);

        }
    }

}
